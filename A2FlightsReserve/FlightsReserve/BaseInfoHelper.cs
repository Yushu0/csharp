using FlightsReserve;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseInfoHelper
{
    private static List<AirlinessPortModel> listAirline = null;
    public static List<AirlinessPortModel> ListAirline
    {
        get
        {
            if (listAirline == null)
            {
                listAirline = GetAirlineList();
            }
            return listAirline;
        }
        set { }
    }
    private static List<AirlinessPortModel> GetAirlineList()
    {
        var FlightDT = CSVHelper.ReadCSV(AppDomain.CurrentDomain.BaseDirectory + "csv\\airlines.csv");

        var tempList = new List<AirlinessPortModel>();
        for (int i = 0; i < FlightDT.Rows.Count; i++)
        {
            var model = new AirlinessPortModel
            {
                ShortName = FlightDT.Rows[i][0].ToString(),
                Name = FlightDT.Rows[i][1].ToString(),
            };
            tempList.Add(model);
        }
        return tempList;
    }


    private static List<AirlinessPortModel> listAirPort = null;
    public static List<AirlinessPortModel> ListAirPort
    {
        get
        {
            if (listAirPort == null)
            {
                listAirPort = GetAirPortList();
            }
            return listAirPort;
        }
        set { }
    }
    private static List<AirlinessPortModel> GetAirPortList()
    {
        var FlightDT = CSVHelper.ReadCSV(AppDomain.CurrentDomain.BaseDirectory + "csv\\airports.csv");

        var tempList = new List<AirlinessPortModel>();
        for (int i = 0; i < FlightDT.Rows.Count; i++)
        {
            var model = new AirlinessPortModel
            {
                ShortName = FlightDT.Rows[i][0].ToString(),
                Name = FlightDT.Rows[i][1].ToString(),
            };
            tempList.Add(model);
        }
        return tempList;
    }




    private static List<FlightsModel> listFlight = null;
    public static List<FlightsModel> ListFlight
    {
        get
        {
            if (listFlight == null)
            {
                listFlight = GetFlightList();
            }
            return listFlight;
        }
        set
        {
            listFlight = value;
        }
    }
    private static List<FlightsModel> GetFlightList()
    {
        var FlightDT = CSVHelper.ReadCSV(AppDomain.CurrentDomain.BaseDirectory + "csv\\flights.csv");

        var tempList = new List<FlightsModel>();
        for (int i = 0; i < FlightDT.Rows.Count; i++)
        {
            var model = new FlightsModel
            {
                FlightNo = FlightDT.Rows[i][0].ToString(),
                From = FlightDT.Rows[i][1].ToString(),
                To = FlightDT.Rows[i][2].ToString(),
                DayOfWeek = FlightDT.Rows[i][3].ToString(),
                Time = FlightDT.Rows[i][4].ToString(),
                Seats = Convert.ToInt32(FlightDT.Rows[i][5].ToString()),
                Cost = FlightDT.Rows[i][6].ToString(),
            };
            tempList.Add(model);
        }
        return tempList;
    }

    private static List<ReservationModel> GetReservationList()
    {
        try
        {
            var fileName = AppDomain.CurrentDomain.BaseDirectory + "\\Reservation" + "\\Reservation.txt";
            var text = System.IO.File.ReadAllText(fileName);
            if (string.IsNullOrEmpty(text)) return new List<ReservationModel>();
            var list = JsonConvert.DeserializeObject<List<ReservationModel>>(text);
            return list;
        }
        catch (Exception ex)
        {
            TestLogManager.Log("Get Reservation exception, message: " + ex.Message);
            return new List<ReservationModel>();
        }
    }

    private static List<ReservationModel> reservationList;

    public static List<ReservationModel> ReservationList
    {
        get
        {
            if (reservationList == null)
            {
                reservationList = GetReservationList();
            }
            return reservationList;
        }
        set
        {
            reservationList = value;
        }
    }


}

public class AirlinessPortModel
{
    public string Name { get; set; }
    public string ShortName { get; set; }
}

public class FlightsModel
{
    public string FlightNo { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string DayOfWeek { get; set; }
    public string Time { get; set; }
    public int Seats { get; set; }
    public string Cost { get; set; }
}

public class ReservationModel
{
    public string ReservationCode { get; set; }
    public string FlightCode { get; set; }
    public string AirlineName { get; set; }
    public string Cost { get; set; }
    public string Name { get; set; }
    public string Citizenship { get; set; }
    /// <summary>
    /// (active or inactive)
    /// </summary>
    public string Status { get; set; }
}


public class CMBModel
{
    public string Name { get; set; }
    public string Value { get; set; }
}
