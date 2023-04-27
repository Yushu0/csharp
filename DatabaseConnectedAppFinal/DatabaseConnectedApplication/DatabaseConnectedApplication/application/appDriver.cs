using DatabaseConnectedApplication.drivers;
using DatabaseConnectedApplication.managers;
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

namespace DatabaseConnectedApplication.application
{
    public partial class appDriver : Form
    {
        private MariaDBDriver DB = new MariaDBDriver();
        public appDriver()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUName.Text))
                {
                    MessageBox.Show("UserName can not be empty !");
                    TestLogManager.Log("Login UserName is empty !");
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPwd.Text))
                {
                    MessageBox.Show("PassWord can not be empty !");
                    TestLogManager.Log("Login PassWord is empty !");
                    return;
                }
                var strSql = " select * from userinfo where LoginName = '" + this.txtUName.Text + "' and PassWord='" + this.txtPwd.Text + "' ";
                DB.Connect();
                var user = DB.Get<userinfo>(strSql).FirstOrDefault();
                DB.Disconnect();
                if (user == null)
                {
                    var strTip = "Login: not found userinfo with UserName is " + this.txtUName.Text + " and PassWord is " + this.txtPwd.Text + " !";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    return;
                }
                TestLogManager.Log("Login successfully !");
                Program.CurrentUser = user;
                this.Hide();
                MovieManagementSystem frm = new MovieManagementSystem();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                TestLogManager.Log("Login ex: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegister ur = new UserRegister();
            ur.ShowDialog();
        }

        private void appDriver_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
