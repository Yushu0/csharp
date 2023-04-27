using DatabaseConnectedApplication.drivers;
using DatabaseConnectedApplication.problemdomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnectedApplication.managers
{
    public partial class MovieManagementSystem : Form
    {
        private Font myFont = new Font("微软雅黑", 10.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
        private MariaDBDriver DB = new MariaDBDriver();

        public MovieManagementSystem()
        {
            InitializeComponent();
        }

        private void MovieManagementSystem_Load(object sender, EventArgs e)
        {
            displayMenu();
            loadMovies();
        }

        private void displayMenu()
        {
            if (Program.CurrentUser != null)
            {
                if (Program.CurrentUser.Role == RoleCode.Admin)
                {
                    //管理员默认全部可以看
                }
                else if (Program.CurrentUser.Role == RoleCode.DefaultUser)
                {
                    this.UsersManagement.Hide();
                    tabControl1.TabPages.Remove(this.UsersManagement);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab.Name == "MoviessManagement")
            {
                loadMovies();
            }
            else if (this.tabControl1.SelectedTab.Name == "UsersManagement")
            {
                loadUsers();
            }
            else if (this.tabControl1.SelectedTab.Name == "MyCenter")
            {
                UserRegister ur = new UserRegister(false, true, Program.CurrentUser.id);
                ur.ShowDialog();
                this.tabControl1.SelectedIndex = 0;
            }
            else if (this.tabControl1.SelectedTab.Name == "ExitApp")
            {
                DialogResult result = MessageBox.Show("Are you sure to exit the system ?", "ExitSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Exit();
                }
            }
        }

        private void loadMovies()
        {
            try
            {
                initAddMovie();
                DB.Connect();
                var list = DB.Get<movies>("select * from movies order by id desc ");
                this.dgvMovie.DataSource = list;
                DB.Disconnect();
            }
            catch (Exception ex)
            {
                var strTip = "loadUsers error ex.Message: " + ex.Message;
                TestLogManager.Log(strTip);
                MessageBox.Show(strTip);
            }
        }

        private void dgvMovie_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvMovie_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (!(e.ColumnIndex >= 0 && e.RowIndex >= 0)) return;
            if (dgvMovie.Columns[e.ColumnIndex].HeaderText != "Operation") return;
            //重绘边框
            e.PaintBackground(e.CellBounds, false);

            //计算占用矩形的尺寸
            SizeF sizeDel = e.Graphics.MeasureString("Delete", myFont);

            //所有文字总宽度
            float fTotal = sizeDel.Width + 4;

            //设置每个“按钮的矩形区域的大小及位置”
            RectangleF rectDel = new RectangleF(e.CellBounds.Left + (e.CellBounds.Width - fTotal) / 2, e.CellBounds.Top + 2, sizeDel.Width, e.CellBounds.Height - 4);

            //设置字体样式
            StringFormat sf = StringFormat.GenericDefault.Clone() as StringFormat;//设置重绘入单元格的字体样式
            sf.FormatFlags = StringFormatFlags.DisplayFormatControl;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisCharacter;

            //定义指定颜色的画刷
            SolidBrush brush = new SolidBrush(Color.Red);
            //填充颜色
            e.Graphics.FillRectangle(brush, rectDel);

            //绘制文字
            e.Graphics.DrawString("Delete", myFont, Brushes.White, rectDel, sf);
            e.Handled = true;
        }

        private void dgvMovie_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.ColumnIndex >= 0 && e.RowIndex >= 0)) return;
            if (dgvMovie.Columns[e.ColumnIndex].HeaderText != "Operation") return;
            Point curPosition = e.Location;//当前鼠标在当前单元格中的坐标
            Graphics g = dgvMovie.CreateGraphics();

            //计算占用矩形的尺寸
            SizeF sizeDel = g.MeasureString("Delete", myFont);

            //所有文字总宽度
            float fTotal = sizeDel.Width + 4;

            Rectangle rectTotal = new Rectangle(0, 0, dgvMovie.Columns[e.ColumnIndex].Width, dgvMovie.Rows[e.RowIndex].Height);

            //设置每个“按钮的矩形区域的大小及位置”
            RectangleF rectDel = new RectangleF(rectTotal.Left + (rectTotal.Width - fTotal) / 2, rectTotal.Top + 2, sizeDel.Width, rectTotal.Height - 4);

            //判断当前鼠标在哪个“按钮”范围内
            string id = dgvMovie.Rows[e.RowIndex].Cells["movieid"].Value.ToString();
            if (rectDel.Contains(curPosition))
            {//Delete
                string title = dgvMovie.Rows[e.RowIndex].Cells["title"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Warning! Are you sure you want to delete the movie information with title " + title + "?",
                    "Tip", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult != DialogResult.Yes) return;
                deleteMovie(id);
            }
        }

        private void deleteMovie(string id)
        {
            if (string.IsNullOrEmpty(id)) return;
            try
            {
                var strSql = "delete from movies where id=" + id;
                DB.Connect();
                var result = DB.Delete(strSql);
                DB.Disconnect();
                if (result)
                {
                    var strTip = "DeleteMovie successfully !";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    loadMovies();
                }
                else
                {
                    var strTip = "DeleteMovie fail ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                }
            }
            catch (Exception ex)
            {
                var strTip = "DeleteMovie error ex.Message: " + ex.Message;
                TestLogManager.Log(strTip);
                MessageBox.Show(strTip);
            }
        }

        private void txtduration_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (((TextBox)sender).Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(((TextBox)sender).Text, out oldf);
                    b2 = float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (((TextBox)sender).Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(((TextBox)sender).Text, out oldf);
                    b2 = float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void txtMovieInYear_KeyPress(object sender, KeyPressEventArgs e)
        {

            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (((TextBox)sender).Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(((TextBox)sender).Text, out oldf);
                    b2 = float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            addMovie();
        }

        private void addMovie()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtduration.Text))
                {
                    var strTip = "AddMovie、 duration can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.txttitle.Text))
                {
                    var strTip = "AddMovie、 title can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtyear.Text))
                {
                    var strTip = "AddMovie、 year can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                var strSql = " INSERT INTO movies(`duration`, `title`, `year`) VALUES ";
                strSql += String.Format("(  {0}, '{1}', {2});", this.txtduration.Text, this.txttitle.Text, this.txtyear.Text);

                var listSql = new List<string>();
                listSql.Add(strSql);
                DB.Connect();
                var result = DB.Insert(listSql);
                DB.Disconnect();
                if (result)
                {
                    var strTipMsg = "AddMovie successfully !";
                    TestLogManager.Log(strTipMsg);
                    MessageBox.Show(strTipMsg);
                    initAddMovie();
                    loadMovies();
                }
                else
                {
                    var strTipMsg = "AddMovie error, please check info again !";
                    TestLogManager.Log(strTipMsg);
                    MessageBox.Show(strTipMsg);
                }
            }
            catch (Exception ex)
            {
                var strTipMsg = "AddMovie、 error ex.Message: " + ex.Message;
                TestLogManager.Log(strTipMsg);
                MessageBox.Show(strTipMsg);
            }
        }

        private void initAddMovie()
        {
            this.txtduration.Text = string.Empty;
            this.txttitle.Text = string.Empty;
            this.txtyear.Text = string.Empty;
            this.txtMovieInYear.Text = string.Empty;
        }

        private void btnPrintMoviesInYear_Click(object sender, EventArgs e)
        {
            printMoviesInYear();
        }

        private void printMoviesInYear()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtMovieInYear.Text))
                {
                    var strTip = "Please input MovieInYear!";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }
                DB.Connect();
                var list = DB.Get<movies>("select * from movies where year like '%" + this.txtMovieInYear.Text + "%' order by id desc ");
                this.dgvMovie.DataSource = list;
                DB.Disconnect();
            }
            catch (Exception ex)
            {
                var strTip = "loadUsers error ex.Message: " + ex.Message;
                TestLogManager.Log(strTip);
                MessageBox.Show(strTip);
            }
        }

        private void btnPrintRandomMovies_Click(object sender, EventArgs e)
        {
            printRandomMovies();
        }

        private void printRandomMovies()
        {
            try
            {
                initAddMovie();
                DB.Connect();
                var list = DB.Get<movies>("select * from  movies ORDER BY RAND() ");
                this.dgvMovie.DataSource = list;
                DB.Disconnect();
            }
            catch (Exception ex)
            {
                var strTip = "loadUsers error ex.Message: " + ex.Message;
                TestLogManager.Log(strTip);
                MessageBox.Show(strTip);
            }
        }

        #region Users
        private void loadUsers()
        {
            try
            {
                DB.Connect();
                var list = DB.Get<userinfo>("select * from  userinfo order by id desc ");
                this.dgvUsers.DataSource = list;
                DB.Disconnect();
            }
            catch (Exception ex)
            {
                var strTip = "loadUsers error ex.Message: " + ex.Message;
                TestLogManager.Log(strTip);
                MessageBox.Show(strTip);
            }
        }

        private void dgvUsers_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (!(e.ColumnIndex >= 0 && e.RowIndex >= 0)) return;
            if (dgvUsers.Columns[e.ColumnIndex].HeaderText != "Operation") return;
            //重绘边框
            e.PaintBackground(e.CellBounds, false);

            //计算占用矩形的尺寸
            SizeF sizeSetRole = e.Graphics.MeasureString("SetRole", myFont);
            SizeF sizeRPW = e.Graphics.MeasureString("ResetPassWord", myFont);

            //所有文字总宽度
            float fTotal = sizeSetRole.Width + sizeRPW.Width + 4;

            //设置每个“按钮的矩形区域的大小及位置”
            RectangleF rectSetRole = new RectangleF(e.CellBounds.Left + (e.CellBounds.Width - fTotal) / 2, e.CellBounds.Top + 2, sizeSetRole.Width, e.CellBounds.Height - 4);
            RectangleF rectRPW = new RectangleF(rectSetRole.Right + 4, e.CellBounds.Top + 2, sizeRPW.Width, e.CellBounds.Height - 4);

            //设置字体样式
            StringFormat sf = StringFormat.GenericDefault.Clone() as StringFormat;//设置重绘入单元格的字体样式
            sf.FormatFlags = StringFormatFlags.DisplayFormatControl;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisCharacter;

            //定义指定颜色的画刷
            SolidBrush brush = new SolidBrush(Color.DeepSkyBlue);
            //填充颜色
            e.Graphics.FillRectangle(brush, rectSetRole);
            e.Graphics.FillRectangle(new SolidBrush(Color.Transparent), rectRPW);

            //绘制文字
            e.Graphics.DrawString("SetRole", myFont, Brushes.White, rectSetRole, sf);
            e.Graphics.DrawString("ResetPassWord", myFont, Brushes.Red, rectRPW, sf);
            e.Handled = true;
        }

        private void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.ColumnIndex >= 0 && e.RowIndex >= 0)) return;
            if (dgvUsers.Columns[e.ColumnIndex].HeaderText != "Operation") return;
            Point curPosition = e.Location;//当前鼠标在当前单元格中的坐标
            Graphics g = dgvUsers.CreateGraphics();

            //计算占用矩形的尺寸
            SizeF sizeSetRole = g.MeasureString("SetRole", myFont);
            SizeF sizeRPW = g.MeasureString("ResetPassWord", myFont);

            //所有文字总宽度
            float fTotal = sizeSetRole.Width + sizeRPW.Width + 4;

            Rectangle rectTotal = new Rectangle(0, 0, dgvUsers.Columns[e.ColumnIndex].Width, dgvUsers.Rows[e.RowIndex].Height);

            //设置每个“按钮的矩形区域的大小及位置”
            RectangleF rectSetRole = new RectangleF(rectTotal.Left + (rectTotal.Width - fTotal) / 2, rectTotal.Top + 2, sizeSetRole.Width, rectTotal.Height - 4);
            RectangleF rectRPW = new RectangleF(rectSetRole.Right + 4, rectTotal.Top + 2, sizeRPW.Width, rectTotal.Height - 4);

            //判断当前鼠标在哪个“按钮”范围内
            string id = dgvUsers.Rows[e.RowIndex].Cells["id"].Value.ToString();
            if (rectSetRole.Contains(curPosition))
            {//SetRole
                SetRole of = new SetRole(Convert.ToInt32(id));
                of.ShowDialog();
                loadUsers();
            }
            else if (rectRPW.Contains(curPosition))
            {//ResetPassWord
                string loginName = dgvUsers.Rows[e.RowIndex].Cells["LoginName"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Warning! Are you sure you want to reset the password with loginame " + loginName + "?",
                    "Tip", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult != DialogResult.Yes) return;

                try
                {
                    var strSql = "update userinfo set PassWord='123456' where id=" + id;
                    DB.Connect();
                    var result = DB.Update(strSql);
                    DB.Disconnect();
                    if (result)
                    {
                        var strTip = "ResetPassWord successfully ! New PassWord: 123456 ";
                        TestLogManager.Log(strTip);
                        MessageBox.Show(strTip);
                        loadUsers();
                    }
                    else
                    {
                        var strTip = "ResetPassWord fail ! ";
                        TestLogManager.Log(strTip);
                        MessageBox.Show(strTip);
                    }
                }
                catch (Exception ex)
                {
                    var strTip = "ResetPassWord error ex.Message: " + ex.Message;
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void addUser()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUName.Text))
                {
                    var strTip = "AddUser、 UserName can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtPwd.Text))
                {
                    var strTip = "AddUser、 PassWord can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtFirstName.Text))
                {
                    var strTip = "AddUser、 FirstName can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtSurName.Text))
                {
                    var strTip = "AddUser、 SurName can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.dtpBirthday.Text))
                {
                    var strTip = "AddUser、 Birthday can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                var strReceiveUpdates = this.cbReceiveUpdates.Checked ? "1" : "0";

                var strSql = " INSERT INTO userinfo(`FirstName`, `SurName`, `Birthday`, `ReceiveUpdates`, `LoginName`, `PassWord`,`Role`) VALUES ";
                strSql += String.Format("(  '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", this.txtFirstName.Text, this.txtSurName.Text, this.dtpBirthday.Text, strReceiveUpdates, this.txtUName.Text, this.txtPwd.Text, "DefaultUser");

                var listSql = new List<string>();
                listSql.Add(strSql);
                DB.Connect();
                var result = DB.Insert(listSql);
                DB.Disconnect();
                if (result)
                {
                    var strTipMsg = "AddUser successfully !";
                    TestLogManager.Log(strTipMsg);
                    MessageBox.Show(strTipMsg);
                    initAddUser();
                    loadUsers();
                }
                else
                {
                    var strTipMsg = "AddUser error, please check info again !";
                    TestLogManager.Log(strTipMsg);
                    MessageBox.Show(strTipMsg);
                }
            }
            catch (Exception ex)
            {
                var strTipMsg = "AddUser、 error ex.Message: " + ex.Message;
                TestLogManager.Log(strTipMsg);
                MessageBox.Show(strTipMsg);
            }
        }

        private void initAddUser()
        {
            this.txtFirstName.Text = string.Empty;
            this.txtSurName.Text = string.Empty;
            this.dtpBirthday.Text = string.Empty;
            this.cbReceiveUpdates.Checked = false;
            this.txtUName.Text = string.Empty;
            this.txtPwd.Text = string.Empty;
        }
        #endregion

        private void MovieManagementSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            System.Environment.Exit(0);
        }

    }
}
