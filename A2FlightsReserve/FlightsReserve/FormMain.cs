using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FlightsReserve
{
    public partial class FormMain : Form
    {
        private Font myFont = new Font("微软雅黑", 10.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = BaseInfoHelper.ReservationList;
            list = list.Where(x => x.Status == "inactive").ToList();
            BaseInfoHelper.ReservationList = list;
            
            
            this.dgv.Font = new Font("宋体", 14);
            LoadCmb();
            BindFlight();
            BindReservation();

            this.dataGridView1.Font = new Font("宋体", 14);
            this.rclbl.Font = new Font("宋体", 14, FontStyle.Bold);
            this.txtRcode.Font = new Font("宋体", 14, FontStyle.Bold);
            this.allbl.Font = new Font("宋体", 14, FontStyle.Bold);
            this.txtAirline.Font = new Font("宋体", 14, FontStyle.Bold);
            this.namelbl.Font = new Font("宋体", 14, FontStyle.Bold);
            this.txtName.Font = new Font("宋体", 14, FontStyle.Bold);
        }

        private void LoadCmb()
        {
            var cmbFromList = BaseInfoHelper.ListFlight.Select(x => x.From).Distinct().ToList();
            var listFrom = new List<CMBModel>();
            listFrom.Add(new CMBModel { Name = "Any", Value = "Any" });
            foreach (var cmbFrom in cmbFromList)
            {
                var model = new CMBModel { Name = cmbFrom, Value = cmbFrom };
                listFrom.Add(model);
            }
            this.cmbFrom.ValueMember = "Value";
            this.cmbFrom.DisplayMember = "Name";
            this.cmbFrom.DataSource = listFrom;


            var cmbToList = BaseInfoHelper.ListFlight.Select(x => x.To).Distinct().ToList();
            var listTo = new List<CMBModel>();
            listTo.Add(new CMBModel { Name = "Any", Value = "Any" });
            foreach (var cmbTo in cmbToList)
            {
                var model = new CMBModel { Name = cmbTo, Value = cmbTo };
                listTo.Add(model);
            }
            this.cmbTo.ValueMember = "Value";
            this.cmbTo.DisplayMember = "Name";
            this.cmbTo.DataSource = listTo;

            var listDayOfWeek = new List<CMBModel>();
            listDayOfWeek.Add(new CMBModel { Name = "Any", Value = "Any" });
            listDayOfWeek.Add(new CMBModel { Name = "Monday", Value = "Monday" });
            listDayOfWeek.Add(new CMBModel { Name = "Tuesday", Value = "Tuesday" });
            listDayOfWeek.Add(new CMBModel { Name = "Wednesday", Value = "Wednesday" });
            listDayOfWeek.Add(new CMBModel { Name = "Thursday", Value = "Thursday" });
            listDayOfWeek.Add(new CMBModel { Name = "Friday", Value = "Friday" });
            listDayOfWeek.Add(new CMBModel { Name = "Saturday", Value = "Saturday" });
            listDayOfWeek.Add(new CMBModel { Name = "Sunday", Value = "Sunday" });

            this.cmbWeek.ValueMember = "Value";
            this.cmbWeek.DisplayMember = "Name";
            this.cmbWeek.DataSource = listDayOfWeek;
        }


        #region 绑定表
        private void BindFlight()
        {
            var tempList = BaseInfoHelper.ListFlight;

            var from = this.cmbFrom.Text;
            var to = this.cmbTo.Text;
            var dayOfWeek = this.cmbWeek.Text;

            if (from != "Any")
            {
                tempList = tempList.Where(x => x.From == from).ToList();
            }
            if (to != "Any")
            {
                tempList = tempList.Where(x => x.To == to).ToList();
            }
            if (dayOfWeek != "Any")
            {
                tempList = tempList.Where(x => x.DayOfWeek == dayOfWeek).ToList();
            }

            tempList = tempList.OrderByDescending(x => x.FlightNo).ToList();

            dgv.DataSource = tempList;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void BindReservation()
        {
            var tempList = BaseInfoHelper.ReservationList;
            var reservationCode = this.txtRcode.Text;
            var airline = this.txtAirline.Text;
            var name = this.txtName.Text;

            if (!string.IsNullOrEmpty(reservationCode))
            {
                tempList = tempList.Where(x => x.ReservationCode.Contains(reservationCode)).ToList();
            }
            if (!string.IsNullOrEmpty(airline))
            {
                tempList = tempList.Where(x => x.AirlineName.Contains(airline)).ToList();
            }
            if (!string.IsNullOrEmpty(name))
            {
                tempList = tempList.Where(x => x.Name.Contains(name)).ToList();
            }

            tempList = tempList.OrderByDescending(x => x.ReservationCode).ToList();

            this.dataGridView1.DataSource = tempList;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        #endregion



        #region 绘制单元格事件，用于添加多个按钮
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (!(e.ColumnIndex >= 0 && e.RowIndex >= 0)) return;
            if (dgv.Columns[e.ColumnIndex].HeaderText != "Operation") return;
            //重绘边框
            e.PaintBackground(e.CellBounds, false);

            //计算占用矩形的尺寸
            SizeF sizeReserve = e.Graphics.MeasureString("MakeReservation", myFont);

            //所有文字总宽度
            float fTotal = sizeReserve.Width + 4;

            //设置每个“按钮的矩形区域的大小及位置”
            RectangleF rectReserve = new RectangleF(e.CellBounds.Left + (e.CellBounds.Width - fTotal) / 2, e.CellBounds.Top + 2, sizeReserve.Width, e.CellBounds.Height - 4);

            //设置字体样式
            StringFormat sf = StringFormat.GenericDefault.Clone() as StringFormat;//设置重绘入单元格的字体样式
            sf.FormatFlags = StringFormatFlags.DisplayFormatControl;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisCharacter;

            //定义指定颜色的画刷
            SolidBrush brush = new SolidBrush(Color.DeepSkyBlue);
            //填充颜色
            e.Graphics.FillRectangle(brush, rectReserve);

            //绘制文字
            e.Graphics.DrawString("MakeReservation", myFont, Brushes.White, rectReserve, sf);

            e.Handled = true;
        }
        #endregion

        #region 鼠标点击单元格事件，用于处理按钮的响应事件
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.ColumnIndex >= 0 && e.RowIndex >= 0)) return;
            if (dgv.Columns[e.ColumnIndex].HeaderText != "Operation") return;
            Point curPosition = e.Location;//当前鼠标在当前单元格中的坐标
            Graphics g = dgv.CreateGraphics();

            //计算占用矩形的尺寸
            SizeF sizeReserve = g.MeasureString("MakeReservation", myFont);

            //所有文字总宽度
            float fTotal = sizeReserve.Width + 4;

            Rectangle rectTotal = new Rectangle(0, 0, dgv.Columns[e.ColumnIndex].Width, dgv.Rows[e.RowIndex].Height);

            //设置每个“按钮的矩形区域的大小及位置”
            RectangleF rectReserve = new RectangleF(rectTotal.Left + (rectTotal.Width - fTotal) / 2, rectTotal.Top + 2, sizeReserve.Width, rectTotal.Height - 4);

            //判断当前鼠标在哪个“按钮”范围内
            string flightNo = dgv.Rows[e.RowIndex].Cells["FlightNo"].Value.ToString();
            if (rectReserve.Contains(curPosition))
            {//预订
                FormReservation of = new FormReservation(flightNo);
                of.ShowDialog();
                of.Dispose();
                BindFlight();
            }
        }
        #endregion

        #region 绘制单元格事件，用于添加多个按钮
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (!(e.ColumnIndex >= 0 && e.RowIndex >= 0)) return;
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText != "Operation") return;
            //重绘边框
            e.PaintBackground(e.CellBounds, false);

            //计算占用矩形的尺寸
            SizeF sizeReserve = e.Graphics.MeasureString("EditReservation", myFont);

            //所有文字总宽度
            float fTotal = sizeReserve.Width + 4;

            //设置每个“按钮的矩形区域的大小及位置”
            RectangleF rectReserve = new RectangleF(e.CellBounds.Left + (e.CellBounds.Width - fTotal) / 2, e.CellBounds.Top + 2, sizeReserve.Width, e.CellBounds.Height - 4);

            //设置字体样式
            StringFormat sf = StringFormat.GenericDefault.Clone() as StringFormat;//设置重绘入单元格的字体样式
            sf.FormatFlags = StringFormatFlags.DisplayFormatControl;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisCharacter;

            //定义指定颜色的画刷
            SolidBrush brush = new SolidBrush(Color.DeepSkyBlue);
            //填充颜色
            e.Graphics.FillRectangle(brush, rectReserve);

            //绘制文字
            e.Graphics.DrawString("EditReservation", myFont, Brushes.White, rectReserve, sf);

            e.Handled = true;
        }
        #endregion

        #region 鼠标点击单元格事件，用于处理按钮的响应事件
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.ColumnIndex >= 0 && e.RowIndex >= 0)) return;
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText != "Operation") return;
            Point curPosition = e.Location;//当前鼠标在当前单元格中的坐标
            Graphics g = dataGridView1.CreateGraphics();

            //计算占用矩形的尺寸
            SizeF sizeReserve = g.MeasureString("EditReservation", myFont);

            //所有文字总宽度
            float fTotal = sizeReserve.Width + 4;

            Rectangle rectTotal = new Rectangle(0, 0, dataGridView1.Columns[e.ColumnIndex].Width, dataGridView1.Rows[e.RowIndex].Height);

            //设置每个“按钮的矩形区域的大小及位置”
            RectangleF rectReserve = new RectangleF(rectTotal.Left + (rectTotal.Width - fTotal) / 2, rectTotal.Top + 2, sizeReserve.Width, rectTotal.Height - 4);

            //判断当前鼠标在哪个“按钮”范围内
            string reservationCode = dataGridView1.Rows[e.RowIndex].Cells["ReservationCode"].Value.ToString();
            if (rectReserve.Contains(curPosition))
            {//修改
                FormEditReservation of = new FormEditReservation(reservationCode);
                of.ShowDialog();
                of.Dispose();
                BindReservation();
            }
        }
        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindFlight();
        }

        private void btnSearchReservation_Click(object sender, EventArgs e)
        {
            BindReservation();
        }
    }
}
