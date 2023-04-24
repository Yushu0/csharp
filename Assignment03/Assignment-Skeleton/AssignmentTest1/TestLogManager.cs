using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest1
{
    public class TestLogManager
    {
        public static readonly string ReservationFolderPath = AppDomain.CurrentDomain.BaseDirectory + "\\TestLog\\";

        public static void Log(string content, string fileName = "test.txt")
        {
            if (string.IsNullOrEmpty(content)) return;
            if (!Directory.Exists(ReservationFolderPath))
            {
                Directory.CreateDirectory(ReservationFolderPath);
            }
            var now = DateTime.Now;
            var filePathName = ReservationFolderPath + fileName;
            var strContent = "\r\n" + now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n" + content + "\r\n\r\n";
            try
            {
                System.IO.File.AppendAllText(filePathName, strContent);
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }
    }
}
