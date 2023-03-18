using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReserveManager
{
    public static readonly string ReservationFolderPath = AppDomain.CurrentDomain.BaseDirectory + "\\Reservation\\";
    public static void persistent(string content, string fileName)
    {
        if (string.IsNullOrEmpty(content)) return;
        if (!Directory.Exists(ReservationFolderPath))
        {
            Directory.CreateDirectory(ReservationFolderPath);
        }

        var filePath = ReservationFolderPath + fileName;
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
        StreamWriter wr = new StreamWriter(fs);
        wr.Write(content);
        wr.Close();
        wr.Dispose();
        fs.Dispose();
    }
}
