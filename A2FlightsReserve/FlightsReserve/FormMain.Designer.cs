namespace FlightsReserve
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbWeek = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.namelbl = new System.Windows.Forms.Label();
            this.allbl = new System.Windows.Forms.Label();
            this.rclbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.ReservationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirlineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Citizenship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtRcode = new System.Windows.Forms.TextBox();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(60, 22);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1269, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 12F);
            this.tabPage1.Location = new System.Drawing.Point(4, 72);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1261, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to our new app.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Traveless";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbWeek);
            this.tabPage2.Controls.Add(this.cmbTo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbFrom);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 72);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1261, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flights";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 141;
            this.label5.Text = "DayOfWeek";
            // 
            // cmbWeek
            // 
            this.cmbWeek.FormattingEnabled = true;
            this.cmbWeek.Location = new System.Drawing.Point(563, 17);
            this.cmbWeek.Name = "cmbWeek";
            this.cmbWeek.Size = new System.Drawing.Size(121, 32);
            this.cmbWeek.TabIndex = 140;
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(256, 18);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(121, 32);
            this.cmbTo.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 138;
            this.label4.Text = "To";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(77, 18);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(121, 32);
            this.cmbFrom.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 136;
            this.label3.Text = "From";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNo,
            this.From,
            this.To,
            this.DayOfWeek,
            this.Time,
            this.Seats,
            this.Cost,
            this.Operation});
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(0, 61);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(1261, 552);
            this.dgv.TabIndex = 135;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // FlightNo
            // 
            this.FlightNo.DataPropertyName = "FlightNo";
            this.FlightNo.HeaderText = "FlightNo";
            this.FlightNo.MinimumWidth = 130;
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            this.FlightNo.Width = 130;
            // 
            // From
            // 
            this.From.DataPropertyName = "From";
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 110;
            this.From.Name = "From";
            this.From.ReadOnly = true;
            this.From.Width = 110;
            // 
            // To
            // 
            this.To.DataPropertyName = "To";
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 110;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Width = 110;
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.DataPropertyName = "DayOfWeek";
            this.DayOfWeek.HeaderText = "DayOfWeek";
            this.DayOfWeek.MinimumWidth = 150;
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.ReadOnly = true;
            this.DayOfWeek.Width = 150;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 100;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Seats
            // 
            this.Seats.DataPropertyName = "Seats";
            this.Seats.HeaderText = "Seats";
            this.Seats.MinimumWidth = 110;
            this.Seats.Name = "Seats";
            this.Seats.ReadOnly = true;
            this.Seats.Width = 110;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 110;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 110;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Operation";
            this.Operation.MinimumWidth = 160;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Width = 160;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(701, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 31);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "Find flights";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtName);
            this.tabPage3.Controls.Add(this.txtAirline);
            this.tabPage3.Controls.Add(this.txtRcode);
            this.tabPage3.Controls.Add(this.namelbl);
            this.tabPage3.Controls.Add(this.allbl);
            this.tabPage3.Controls.Add(this.rclbl);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btnSearchReservation);
            this.tabPage3.Location = new System.Drawing.Point(4, 72);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1261, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(545, 10);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(256, 24);
            this.namelbl.TabIndex = 149;
            this.namelbl.Text = "Traveler’sFullName";
            // 
            // allbl
            // 
            this.allbl.AutoSize = true;
            this.allbl.Location = new System.Drawing.Point(323, 12);
            this.allbl.Name = "allbl";
            this.allbl.Size = new System.Drawing.Size(101, 24);
            this.allbl.TabIndex = 146;
            this.allbl.Text = "Airline";
            // 
            // rclbl
            // 
            this.rclbl.AutoSize = true;
            this.rclbl.Location = new System.Drawing.Point(3, 12);
            this.rclbl.Name = "rclbl";
            this.rclbl.Size = new System.Drawing.Size(205, 24);
            this.rclbl.TabIndex = 144;
            this.rclbl.Text = "ReservationCode";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationCode,
            this.FlightCode,
            this.AirlineName,
            this.Cost1,
            this.Name1111,
            this.Citizenship,
            this.Status,
            this.dataGridViewButtonColumn1});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 552);
            this.dataGridView1.TabIndex = 143;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchReservation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchReservation.ForeColor = System.Drawing.Color.White;
            this.btnSearchReservation.Location = new System.Drawing.Point(910, 6);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(145, 31);
            this.btnSearchReservation.TabIndex = 142;
            this.btnSearchReservation.Text = "Find Reservation";
            this.btnSearchReservation.UseVisualStyleBackColor = false;
            this.btnSearchReservation.Click += new System.EventHandler(this.btnSearchReservation_Click);
            // 
            // ReservationCode
            // 
            this.ReservationCode.DataPropertyName = "ReservationCode";
            this.ReservationCode.HeaderText = "ReservationCode";
            this.ReservationCode.MinimumWidth = 180;
            this.ReservationCode.Name = "ReservationCode";
            this.ReservationCode.ReadOnly = true;
            this.ReservationCode.Width = 180;
            // 
            // FlightCode
            // 
            this.FlightCode.DataPropertyName = "FlightCode";
            this.FlightCode.HeaderText = "FlightCode";
            this.FlightCode.MinimumWidth = 140;
            this.FlightCode.Name = "FlightCode";
            this.FlightCode.ReadOnly = true;
            this.FlightCode.Width = 140;
            // 
            // AirlineName
            // 
            this.AirlineName.DataPropertyName = "AirlineName";
            this.AirlineName.HeaderText = "AirlineName";
            this.AirlineName.MinimumWidth = 170;
            this.AirlineName.Name = "AirlineName";
            this.AirlineName.ReadOnly = true;
            this.AirlineName.Width = 170;
            // 
            // Cost1
            // 
            this.Cost1.DataPropertyName = "Cost";
            this.Cost1.HeaderText = "Cost";
            this.Cost1.MinimumWidth = 110;
            this.Cost1.Name = "Cost1";
            this.Cost1.ReadOnly = true;
            this.Cost1.Width = 110;
            // 
            // Name1111
            // 
            this.Name1111.DataPropertyName = "Name";
            this.Name1111.HeaderText = "Name";
            this.Name1111.MinimumWidth = 120;
            this.Name1111.Name = "Name1111";
            this.Name1111.ReadOnly = true;
            this.Name1111.Width = 120;
            // 
            // Citizenship
            // 
            this.Citizenship.DataPropertyName = "Citizenship";
            this.Citizenship.HeaderText = "Citizenship";
            this.Citizenship.MinimumWidth = 140;
            this.Citizenship.Name = "Citizenship";
            this.Citizenship.ReadOnly = true;
            this.Citizenship.Width = 140;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 110;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 110;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Operation";
            this.dataGridViewButtonColumn1.MinimumWidth = 160;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Width = 160;
            // 
            // txtRcode
            // 
            this.txtRcode.Location = new System.Drawing.Point(181, 7);
            this.txtRcode.Name = "txtRcode";
            this.txtRcode.Size = new System.Drawing.Size(121, 35);
            this.txtRcode.TabIndex = 150;
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(410, 7);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(121, 35);
            this.txtAirline.TabIndex = 151;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(775, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 35);
            this.txtName.TabIndex = 152;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 683);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traveless";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbWeek;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label allbl;
        private System.Windows.Forms.Label rclbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewButtonColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirlineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1111;
        private System.Windows.Forms.DataGridViewTextBoxColumn Citizenship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAirline;
        private System.Windows.Forms.TextBox txtRcode;
    }
}

