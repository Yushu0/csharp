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
    public partial class SetRole : Form
    {
        private MariaDBDriver DB = new MariaDBDriver();
        private int ID;
        public SetRole(int id = 0)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void SetRole_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DB.Connect();
                var user = DB.Get<userinfo>(" select * from userinfo where id=" + ID).FirstOrDefault();
                if (user != null)
                {
                    this.cmbRole.Text = user.Role;
                }
                DB.Disconnect();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var strSql = "update userinfo set Role='" + this.cmbRole.Text + "' where id=" + ID;
                DB.Connect();
                var result = DB.Update(strSql);
                DB.Disconnect();
                if (result)
                {
                    var strTip = "SetRole successfully ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    var strTip = "SetRole fail ! ";
                    TestLogManager.Log(strTip);
                    MessageBox.Show(strTip);
                }
            }
            catch (Exception ex)
            {
                var strTip = "SetRole error ex.Message: " + ex.Message;
                TestLogManager.Log(strTip);
                MessageBox.Show(strTip);
            }
        }
    }
}
