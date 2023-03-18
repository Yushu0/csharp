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
    public partial class FormEditReservation : Form
    {
        public string Id = string.Empty;
        public FormEditReservation(string id = "")
        {
            this.Id = id;
            InitializeComponent();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                LoadEditReservation();
            }
        }

        private void LoadEditReservation()
        {
            var reservation = BaseInfoHelper.ReservationList.Where(x => x.ReservationCode == Id).FirstOrDefault();
            if (reservation == null)
            {
                MessageBox.Show("Reservation data is lost !");
                return;
            }

            this.txtRCode.Text = reservation.ReservationCode;
            this.txtFlightNo.Text = reservation.FlightCode;
            this.txtAirline.Text = reservation.AirlineName;
            this.txtCost.Text = reservation.Cost;
            this.txtName.Text = reservation.Name;
            this.txtCitizenship.Text = reservation.Citizenship;
            this.cmbStatus.Text = reservation.Status;
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
            var list = BaseInfoHelper.ReservationList;
            var entity = list.Where(x => x.ReservationCode == this.txtRCode.Text).FirstOrDefault();
            if (entity == null)
            {
                MessageBox.Show("Reservation data is missing !");
                TestLogManager.Log("Reservation data is missing !");
                return;
            }

            if (entity.Status != this.cmbStatus.Text)
            {
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

                if (this.cmbStatus.Text == "active")
                {
                    flight.Seats = flight.Seats - 1;
                }
                else
                {
                    flight.Seats = flight.Seats + 1;
                }
                var tempFlightList = BaseInfoHelper.ListFlight.Where(x => x.FlightNo != this.txtFlightNo.Text).ToList();
                tempFlightList.Add(flight);
                BaseInfoHelper.ListFlight = tempFlightList;
            }

            entity.Name = this.txtName.Text;
            entity.Citizenship = this.txtCitizenship.Text;
            entity.Status = this.cmbStatus.Text;

            var tempList = list.Where(x => x.ReservationCode != this.txtRCode.Text).ToList();
            tempList.Add(entity);
            ReserveManager.persistent(JsonConvert.SerializeObject(tempList), "Reservation.txt");

            TestLogManager.Log("Update Reservation successfully !");
            MessageBox.Show("Update Reservation successfully !");

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
