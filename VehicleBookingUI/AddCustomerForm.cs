using System;
using System.Windows.Forms;
using VehicleBookingLibrary;

namespace VehicleBookingUI
{
    public partial class AddCustomerForm : Form
    {
        private BookingForm BookingForm { get; set; }
        private DataService DataService { get; set; }

        private bool CustomerInputIsValid { get; set; }

        public AddCustomerForm(BookingForm bookingForm)
        {
            InitializeComponent();

            this.BookingForm = bookingForm;
            this.DataService = DataService.GetDataService();
        }

        
        private void ValidateCustomerInputAndDisplayErrors()
        {
            this.CustomerInputIsValid = true;

            this.firstNameErrorLabel.Visible = false;
            this.lastNameErrorLabel.Visible = false;
            this.contactNumberErrorLabel.Visible = false;

            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            string contactNumber = this.contactNumberTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || ContainsDigits(firstName))
            {
                this.CustomerInputIsValid = false;
                this.firstNameErrorLabel.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(lastName) || ContainsDigits(lastName))
            {
                this.CustomerInputIsValid = false;
                this.lastNameErrorLabel.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(contactNumber) || ContainsCharacters(contactNumber) || contactNumber.Length < 10)
            {
                this.CustomerInputIsValid = false;
                this.contactNumberErrorLabel.Visible = true;
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

        private bool ContainsCharacters(string str)
        {
            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    return true;
                }
            }

            return false;
        }

        private void ResetCustomerForm()
        {
            this.firstNameTextBox.ResetText();
            this.lastNameTextBox.ResetText();
            this.contactNumberTextBox.ResetText();

            this.firstNameErrorLabel.Visible = false;
            this.lastNameErrorLabel.Visible = false;
            this.contactNumberErrorLabel.Visible = false;
        }



        /* Events */
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            ValidateCustomerInputAndDisplayErrors();

            if (this.CustomerInputIsValid)
            {
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string contactNumber = contactNumberTextBox.Text;

                Customer customer = new Customer()
                {
                    Id = this.DataService.GetNextCustomerId(),
                    FirstName = firstName,
                    LastName = lastName,
                    ContactNumber = contactNumber
                };

                this.DataService.SaveCustomer(customer);

                this.BookingForm.RefreshCustomersBinding();
                this.ResetCustomerForm();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.ResetCustomerForm();
        }

        private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BookingForm.Enabled = true;
        }
    }
}
