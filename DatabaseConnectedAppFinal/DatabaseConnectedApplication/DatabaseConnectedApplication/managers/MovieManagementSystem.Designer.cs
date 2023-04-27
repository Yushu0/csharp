namespace DatabaseConnectedApplication.managers
{
    partial class MovieManagementSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MoviesManagement = new System.Windows.Forms.TabPage();
            this.btnPrintRandomMovies = new System.Windows.Forms.Button();
            this.btnPrintMoviesInYear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMovieInYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.movieid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersManagement = new System.Windows.Forms.TabPage();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cbReceiveUpdates = new System.Windows.Forms.CheckBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveUpdates = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyCenter = new System.Windows.Forms.TabPage();
            this.ExitApp = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.MoviesManagement.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.UsersManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.MoviesManagement);
            this.tabControl1.Controls.Add(this.UsersManagement);
            this.tabControl1.Controls.Add(this.MyCenter);
            this.tabControl1.Controls.Add(this.ExitApp);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 578);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // MoviesManagement
            // 
            this.MoviesManagement.Controls.Add(this.btnPrintRandomMovies);
            this.MoviesManagement.Controls.Add(this.btnPrintMoviesInYear);
            this.MoviesManagement.Controls.Add(this.label10);
            this.MoviesManagement.Controls.Add(this.txtMovieInYear);
            this.MoviesManagement.Controls.Add(this.label8);
            this.MoviesManagement.Controls.Add(this.txtyear);
            this.MoviesManagement.Controls.Add(this.label3);
            this.MoviesManagement.Controls.Add(this.label7);
            this.MoviesManagement.Controls.Add(this.txttitle);
            this.MoviesManagement.Controls.Add(this.txtduration);
            this.MoviesManagement.Controls.Add(this.btnAddMovie);
            this.MoviesManagement.Controls.Add(this.panel2);
            this.MoviesManagement.Location = new System.Drawing.Point(4, 22);
            this.MoviesManagement.Name = "MoviesManagement";
            this.MoviesManagement.Padding = new System.Windows.Forms.Padding(3);
            this.MoviesManagement.Size = new System.Drawing.Size(1050, 552);
            this.MoviesManagement.TabIndex = 0;
            this.MoviesManagement.Text = "MoviesManagement";
            this.MoviesManagement.UseVisualStyleBackColor = true;
            // 
            // btnPrintRandomMovies
            // 
            this.btnPrintRandomMovies.Location = new System.Drawing.Point(499, 60);
            this.btnPrintRandomMovies.Name = "btnPrintRandomMovies";
            this.btnPrintRandomMovies.Size = new System.Drawing.Size(131, 23);
            this.btnPrintRandomMovies.TabIndex = 40;
            this.btnPrintRandomMovies.Text = "printRandomMovies";
            this.btnPrintRandomMovies.UseVisualStyleBackColor = true;
            this.btnPrintRandomMovies.Click += new System.EventHandler(this.btnPrintRandomMovies_Click);
            // 
            // btnPrintMoviesInYear
            // 
            this.btnPrintMoviesInYear.Location = new System.Drawing.Point(250, 60);
            this.btnPrintMoviesInYear.Name = "btnPrintMoviesInYear";
            this.btnPrintMoviesInYear.Size = new System.Drawing.Size(124, 23);
            this.btnPrintMoviesInYear.TabIndex = 39;
            this.btnPrintMoviesInYear.Text = "printMoviesInYear";
            this.btnPrintMoviesInYear.UseVisualStyleBackColor = true;
            this.btnPrintMoviesInYear.Click += new System.EventHandler(this.btnPrintMoviesInYear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 37;
            this.label10.Text = "MoviesInYear:";
            // 
            // txtMovieInYear
            // 
            this.txtMovieInYear.Location = new System.Drawing.Point(119, 62);
            this.txtMovieInYear.Name = "txtMovieInYear";
            this.txtMovieInYear.Size = new System.Drawing.Size(128, 21);
            this.txtMovieInYear.TabIndex = 35;
            this.txtMovieInYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMovieInYear_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "year:";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(499, 17);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(128, 21);
            this.txtyear.TabIndex = 33;
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "duration:";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(298, 17);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(128, 21);
            this.txttitle.TabIndex = 30;
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(95, 17);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(128, 21);
            this.txtduration.TabIndex = 29;
            this.txtduration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtduration_KeyPress);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(663, 15);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 28;
            this.btnAddMovie.Text = "AddMovie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvMovie);
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 450);
            this.panel2.TabIndex = 3;
            // 
            // dgvMovie
            // 
            this.dgvMovie.AllowUserToAddRows = false;
            this.dgvMovie.AllowUserToDeleteRows = false;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieid,
            this.duration,
            this.title,
            this.year,
            this.StrOperation});
            this.dgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovie.Location = new System.Drawing.Point(0, 0);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.ReadOnly = true;
            this.dgvMovie.RowTemplate.Height = 23;
            this.dgvMovie.Size = new System.Drawing.Size(1050, 450);
            this.dgvMovie.TabIndex = 0;
            this.dgvMovie.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMovie_CellBeginEdit);
            this.dgvMovie.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMovie_CellMouseClick);
            this.dgvMovie.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMovie_CellPainting);
            // 
            // movieid
            // 
            this.movieid.DataPropertyName = "id";
            this.movieid.HeaderText = "id";
            this.movieid.Name = "movieid";
            this.movieid.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "duration";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // StrOperation
            // 
            this.StrOperation.DataPropertyName = "Operation";
            this.StrOperation.HeaderText = "Operation";
            this.StrOperation.MinimumWidth = 200;
            this.StrOperation.Name = "StrOperation";
            this.StrOperation.ReadOnly = true;
            this.StrOperation.Width = 230;
            // 
            // UsersManagement
            // 
            this.UsersManagement.Controls.Add(this.btnAddUser);
            this.UsersManagement.Controls.Add(this.cbReceiveUpdates);
            this.UsersManagement.Controls.Add(this.dtpBirthday);
            this.UsersManagement.Controls.Add(this.label4);
            this.UsersManagement.Controls.Add(this.label5);
            this.UsersManagement.Controls.Add(this.label6);
            this.UsersManagement.Controls.Add(this.txtSurName);
            this.UsersManagement.Controls.Add(this.txtFirstName);
            this.UsersManagement.Controls.Add(this.label2);
            this.UsersManagement.Controls.Add(this.label1);
            this.UsersManagement.Controls.Add(this.txtPwd);
            this.UsersManagement.Controls.Add(this.txtUName);
            this.UsersManagement.Controls.Add(this.panel1);
            this.UsersManagement.Location = new System.Drawing.Point(4, 22);
            this.UsersManagement.Name = "UsersManagement";
            this.UsersManagement.Padding = new System.Windows.Forms.Padding(3);
            this.UsersManagement.Size = new System.Drawing.Size(1050, 552);
            this.UsersManagement.TabIndex = 1;
            this.UsersManagement.Text = "UsersManagement";
            this.UsersManagement.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(728, 39);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 27;
            this.btnAddUser.Text = "AddUser";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cbReceiveUpdates
            // 
            this.cbReceiveUpdates.AutoSize = true;
            this.cbReceiveUpdates.Location = new System.Drawing.Point(491, 61);
            this.cbReceiveUpdates.Name = "cbReceiveUpdates";
            this.cbReceiveUpdates.Size = new System.Drawing.Size(108, 16);
            this.cbReceiveUpdates.TabIndex = 26;
            this.cbReceiveUpdates.Text = "ReceiveUpdates";
            this.cbReceiveUpdates.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(548, 25);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(128, 21);
            this.dtpBirthday.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "SurName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "FirstName:";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(319, 25);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.PasswordChar = '*';
            this.txtSurName.Size = new System.Drawing.Size(128, 21);
            this.txtSurName.TabIndex = 21;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(93, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(128, 21);
            this.txtFirstName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "PassWord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "UserName:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(319, 59);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(128, 21);
            this.txtPwd.TabIndex = 13;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(93, 59);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(128, 21);
            this.txtUName.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 458);
            this.panel1.TabIndex = 2;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.SurName,
            this.Birthday,
            this.ReceiveUpdates,
            this.LoginName,
            this.PassWord,
            this.Role,
            this.Operation});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 23;
            this.dgvUsers.Size = new System.Drawing.Size(1050, 458);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvUsers_CellBeginEdit);
            this.dgvUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_CellMouseClick);
            this.dgvUsers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsers_CellPainting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // SurName
            // 
            this.SurName.DataPropertyName = "SurName";
            this.SurName.HeaderText = "SurName";
            this.SurName.Name = "SurName";
            this.SurName.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // ReceiveUpdates
            // 
            this.ReceiveUpdates.DataPropertyName = "ReceiveUpdates";
            this.ReceiveUpdates.FalseValue = "0";
            this.ReceiveUpdates.HeaderText = "ReceiveUpdates";
            this.ReceiveUpdates.Name = "ReceiveUpdates";
            this.ReceiveUpdates.ReadOnly = true;
            this.ReceiveUpdates.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiveUpdates.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReceiveUpdates.TrueValue = "1";
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "LoginName";
            this.LoginName.Name = "LoginName";
            this.LoginName.ReadOnly = true;
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.HeaderText = "PassWord";
            this.PassWord.Name = "PassWord";
            this.PassWord.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Operation";
            this.Operation.MinimumWidth = 200;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Width = 230;
            // 
            // MyCenter
            // 
            this.MyCenter.Location = new System.Drawing.Point(4, 22);
            this.MyCenter.Name = "MyCenter";
            this.MyCenter.Padding = new System.Windows.Forms.Padding(3);
            this.MyCenter.Size = new System.Drawing.Size(1050, 552);
            this.MyCenter.TabIndex = 2;
            this.MyCenter.Text = "MyCenter";
            this.MyCenter.UseVisualStyleBackColor = true;
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(4, 22);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Padding = new System.Windows.Forms.Padding(3);
            this.ExitApp.Size = new System.Drawing.Size(1050, 552);
            this.ExitApp.TabIndex = 3;
            this.ExitApp.Text = "ExitApp";
            this.ExitApp.UseVisualStyleBackColor = true;
            // 
            // MovieManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 602);
            this.Controls.Add(this.tabControl1);
            this.Name = "MovieManagementSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieManagementSystem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MovieManagementSystem_FormClosed);
            this.Load += new System.EventHandler(this.MovieManagementSystem_Load);
            this.tabControl1.ResumeLayout(false);
            this.MoviesManagement.ResumeLayout(false);
            this.MoviesManagement.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.UsersManagement.ResumeLayout(false);
            this.UsersManagement.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MoviesManagement;
        private System.Windows.Forms.TabPage UsersManagement;
        private System.Windows.Forms.TabPage MyCenter;
        private System.Windows.Forms.TabPage ExitApp;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.CheckBox cbReceiveUpdates;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReceiveUpdates;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.Button btnPrintRandomMovies;
        private System.Windows.Forms.Button btnPrintMoviesInYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMovieInYear;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieid;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrOperation;
    }
}