using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightsReserve
{
    public partial class FormReservation : Form
    {
        public string FlightNo = string.Empty;
        public FormReservation(string flightNo = "")
        {
            this.FlightNo = flightNo;
            InitializeComponent();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FlightNo))
            {
                LoadMakeReservation();
            }
        }

        private void LoadMakeReservation()
        {
            var flight = BaseInfoHelper.ListFlight.Where(x => x.FlightNo == FlightNo).FirstOrDefault();
            var airline = BaseInfoHelper.ListAirline.Where(x => FlightNo.Contains(x.ShortName)).FirstOrDefault();

            this.txtFlightNo.Text = FlightNo;
            this.txtAirline.Text = airline == null ? "" : airline.Name;
            this.txtDayOfWeek.Text = flight == null ? "" : flight.DayOfWeek;
            this.txtTime.Text = flight == null ? "" : flight.Time;
            this.txtCost.Text = flight == null ? "" : flight.Cost;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Name could not be empty !");
                TestLogManager.Log("Name could not be empty !");
                return;
            }

            if (string.IsNullOrEmpty(this.txtCitizenship.Text))
            {
                MessageBox.Show("Citizenship could not be empty !");
                TestLogManager.Log("Citizenship could not be empty !");
                return;
            }

            #region check flight could be reserve
            var flight = BaseInfoHelper.ListFlight.Where(x => x.FlightNo == this.txtFlightNo.Text).FirstOrDefault();
            if (flight == null)
            {
                MessageBox.Show("Flight data is missing !");
                TestLogManager.Log("Flight data is missing !");
                return;
            }

            if (flight.Seats <= 0)
            {
                MessageBox.Show("No availabe seat could be reserved !");
                TestLogManager.Log("No availabe seat could be reserved !");
                return;
            }

            #endregion

            var reservationList = BaseInfoHelper.ReservationList;
            var rc = ReservationManager.GenerateReservationCode();
            do
            {
                rc = ReservationManager.GenerateReservationCode();
            } while (reservationList.Exists(x => x.ReservationCode == rc));

            var model = new ReservationModel
            {
                ReservationCode = rc,
                FlightCode = this.txtFlightNo.Text,
                AirlineName = this.txtAirline.Text,
                Cost = this.txtCost.Text,
                Name = this.txtName.Text,
                Citizenship = this.txtCitizenship.Text,
                Status = "active"
            };

            reservationList.Add(model);
            var strJson = JsonConvert.SerializeObject(reservationList);
            ReserveManager.persistent(strJson, "Reservation.txt");

            flight.Seats = flight.Seats - 1;
            var tempList = BaseInfoHelper.ListFlight.Where(x => x.FlightNo != model.FlightCode).ToList();
            tempList.Add(flight);
            BaseInfoHelper.ListFlight = tempList;

            TestLogManager.Log("Add Reservation successfully !");
            MessageBox.Show("Add Reservation successfully !");

            ClosePage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClosePage();
        }

        private void ClosePage()
        {
            this.Close();
        }
    }
}
