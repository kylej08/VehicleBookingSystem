using System;
using System.Windows.Forms;
using VehicleBookingLibrary;

namespace VehicleBookingUI
{
    public partial class AddVehicleForm : Form
    {
        private BookingForm BookingForm { get; set; }
        private DataService DataService { get; set; }
        private bool VehicleInputIsValid { get; set; }

        public AddVehicleForm(BookingForm bookingForm)
        {
            InitializeComponent();

            this.BookingForm = bookingForm;
            this.DataService = DataService.GetDataService();
        }


        private void ResetVehicleForm()
        {
            this.makeTextBox.ResetText();
            this.modelTextBox.ResetText();
            this.registrationNumberTextBox.ResetText();

            this.DisableAllErrorLabels();
        }

        private void DisableAllErrorLabels()
        {
            this.makeErrorLabel.Visible = false;
            this.modelErrorLabel.Visible = false;
            this.registrationNumberErrorLabel.Visible = false;
        }

        private void ValidateVehicleInputAndDisplayErrors()
        {
            this.VehicleInputIsValid = true;

            this.DisableAllErrorLabels();

            string model = this.modelTextBox.Text;
            string make = this.makeTextBox.Text;
            string registrationNumber = this.registrationNumberTextBox.Text;

            if (string.IsNullOrEmpty(model) || ContainsDigits(make))
            {
                this.VehicleInputIsValid = false;
                this.modelErrorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(make))
            {
                this.VehicleInputIsValid = false;
                this.makeErrorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(registrationNumber))
            {
                this.VehicleInputIsValid = false;
                this.registrationNumberErrorLabel.Visible = true;
            }
        }

        private bool ContainsDigits(string str)
        {
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    return true;
                }
            }

            return false;
        }

        /* Events */

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.ResetVehicleForm();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            ValidateVehicleInputAndDisplayErrors();

            if (this.VehicleInputIsValid)
            {
                string make = this.makeTextBox.Text;
                string model = this.modelTextBox.Text;
                string registrationNumber = this.registrationNumberTextBox.Text;

                Vehicle vehicle = new Vehicle()
                {
                    Id = this.DataService.GetNextVehicleId(),
                    Make = make,
                    Model = model,
                    RegistrationNumber = registrationNumber
                };

                this.DataService.SaveVehicle(vehicle);

                this.BookingForm.RefreshVehiclesBinding();
                this.ResetVehicleForm();
            }
        }

        private void AddVehicleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BookingForm.Enabled = true;
        }
    }
}
