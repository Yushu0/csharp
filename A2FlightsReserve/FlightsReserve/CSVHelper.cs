using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CSVHelper
{
    public static DataTable ReadCSV(string filePathName, bool IsIncludeTitle = false)
    {
        //实例化一个datatable用来存储数据
        DataTable dt = new DataTable();

        //文件流读取
        System.IO.FileStream fs = new System.IO.FileStream(filePathName, System.IO.FileMode.Open);
        System.IO.StreamReader sr = new System.IO.StreamReader(fs, Encoding.GetEncoding("gb2312"));

        string tempText = "";
        while ((tempText = sr.ReadLine()) != null)
        {
            var _columnArr = tempText.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (!IsIncludeTitle)
            {
                foreach (string str in _columnArr)
                {
                    dt.Columns.Add("表头【" + str + "】");
                }
                IsIncludeTitle = true;
            }

            dt.Rows.Add(_columnArr);

        }
        //关闭流
        sr.Close();
        fs.Close();
        return dt;
    }
}
