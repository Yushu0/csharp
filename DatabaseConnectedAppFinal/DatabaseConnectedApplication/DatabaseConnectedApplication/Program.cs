using DatabaseConnectedApplication.application;
using DatabaseConnectedApplication.problemdomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnectedApplication
{
    static class Program
    {
        public static userinfo CurrentUser = null;
        /// <summary>
        /// Main entrance
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestLogManager.Log("application start ");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new appDriver());
        }
    }
}
