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
    public partial class UserRegister : Form
    {
        private MariaDBDriver DB = new MariaDBDriver();
        private bool IsView = false;
        private int ID;
        public UserRegister(bool IsAdd = false, bool isView = false, int id = 0)
        {
            InitializeComponent();
            if (IsAdd)
            {
                this.FindForm().Text = "AddUser";
            }
            if (id != 0)
            {
                ID = id;
            }
            IsView = isView;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUName.Text))
                {
                    var strTip = "Register、 UserName can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtPwd.Text))
                {
                    var strTip = "Register、 PassWord can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtFirstName.Text))
                {
                    var strTip = "Register、 FirstName can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtSurName.Text))
                {
                    var strTip = "Register、 SurName can not be empty ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }

                if (string.IsNullOrEmpty(this.dtpBirthday.Text))
                {
                    var strTip = "Register、 Birthday can not be empty ! ";
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
                    var strTipMsg = "Register successfully !";
                    TestLogManager.Log(strTipMsg);
                    MessageBox.Show(strTipMsg);
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    var strTipMsg = "Register error, please check info again !";
                    TestLogManager.Log(strTipMsg);
                    MessageBox.Show(strTipMsg);
                }
            }
            catch (Exception ex)
            {
                var strTipMsg = "Register、 error ex.Message: " + ex.Message;
                TestLogManager.Log(strTipMsg);
                MessageBox.Show(strTipMsg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            if (IsView)
            {
                this.FindForm().Text = "MyUserInfo";
                if (ID == 0) return;
                DB.Connect();
                var user = DB.Get<userinfo>("select * from userinfo where ID=" + ID).FirstOrDefault();
                DB.Disconnect();
                if (user == null) return;

                SetData(user);

                this.btnRegister.Visible = false;
                this.btnCancel.Visible = false;
                var controls = this.FindForm().Controls;
                foreach (var control in controls)
                {
                    if (control is TextBox)
                    {
                        var ct = (TextBox)control;
                        ct.ReadOnly = true;
                    }
                    if (control is DateTimePicker)
                    {
                        var ct = (DateTimePicker)control;
                        ct.Enabled = false;
                    }
                    if (control is CheckBox)
                    {
                        var ct = (CheckBox)control;
                        ct.Enabled = false;
                    }
                }
            }
        }

        private void SetData(userinfo user)
        {
            this.txtFirstName.Text = user.FirstName;
            this.txtSurName.Text = user.SurName;
            this.txtUName.Text = user.LoginName;
            this.txtPwd.Text = user.PassWord;
            this.dtpBirthday.Text = user.Birthday;
            this.cbReceiveUpdates.Checked = user.ReceiveUpdates == "1";
        }
    }
}
