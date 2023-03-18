using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReservationManager
{
    public static string GenerateReservationCode()
    {
        string charArr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var strHeader = charArr[new Random().Next(25)].ToString();
        var strNo = new Random().Next(1000, 9999);
        return strHeader + strNo;
    }
}
