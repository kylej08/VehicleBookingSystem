using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VehicleBookingLibrary;

namespace VehicleBookingUI
{
    public partial class BookingForm : Form
    {
        private BindingSource BookingsBinding { get; set; }
        private BindingSource CustomersBinding { get; set; }
        private BindingSource VehiclesBinding { get; set; }

        private DataService DataService { get; set; }

        private List<Booking> BookingList { get; set; }
        private List<Customer> CustomerList { get; set; }
        private List<Vehicle> VehicleList { get; set; }

        public bool BookingInputIsValid { get; set; }


        public BookingForm()
        {
            InitializeComponent();

            SetupBookingTimePickers();

            this.DataService = DataService.GetDataService();
            this.DataService.SetupDatabase();
          
            this.SetupBookingsGridView();
            this.BookingList = this.DataService.GetBookingsAsList();
            this.BookingList.Sort(new BookingRowSorter());

            this.CustomerList = this.DataService.GetCustomersAsList();
            this.VehicleList = this.DataService.GetVehiclesAsList();

            this.bookingDateTimePicker.MinDate = DateTime.Today;

            this.SetupBindings();
        }


        private void SetupBookingsGridView()
        {
            this.bookingDataGridView.AutoGenerateColumns = false;

            DataGridViewColumn idColumn = CreateDataGridColumn("Id", "Id");
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.bookingDataGridView.Columns.Add(idColumn);

            DataGridViewColumn dateColumn = CreateDataGridColumn("Booking Date", "DisplayDate");
            dateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.bookingDataGridView.Columns.Add(dateColumn);

            DataGridViewColumn startTimeColumn = CreateDataGridColumn("Start Time", "DisplayStartTime");
            startTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.bookingDataGridView.Columns.Add(startTimeColumn);

            DataGridViewColumn endTimeColumn = CreateDataGridColumn("End Time", "DisplayEndTime");
            endTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.bookingDataGridView.Columns.Add(endTimeColumn);

            DataGridViewColumn customerColumn = CreateDataGridColumn("Customer", "DisplayCustomer");
            this.bookingDataGridView.Columns.Add(customerColumn);

            DataGridViewColumn vehicleColumn = CreateDataGridColumn("Vehicle", "DisplayVehicle");
            this.bookingDataGridView.Columns.Add(vehicleColumn);

            DataGridViewColumn notesColumn = CreateDataGridColumn("Notes", "Notes");
            this.bookingDataGridView.Columns.Add(notesColumn);
        }

        private void SetupBookingTimePickers()
        {
            this.bookingStartTimePicker.Format = DateTimePickerFormat.Custom;
            this.bookingStartTimePicker.ShowUpDown = true;
            this.bookingStartTimePicker.CustomFormat = "h:mm tt";

            this.bookingEndTimePicker.Format = DateTimePickerFormat.Custom;
            this.bookingEndTimePicker.ShowUpDown = true;
            this.bookingEndTimePicker.CustomFormat = "h:mm tt";
        }

        private DataGridViewTextBoxColumn CreateDataGridColumn(string columnName, string dataPropertyName)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = columnName;
            column.DataPropertyName = dataPropertyName;

            return column;
        }

        private void SetupBindings()
        {
            this.BookingsBinding = new BindingSource();
            this.BookingsBinding.DataSource = this.BookingList;
            this.bookingDataGridView.DataSource = this.BookingsBinding;

            this.CustomersBinding = new BindingSource();
            this.CustomersBinding.DataSource = this.CustomerList;
            this.bookingCustomerComboBox.DataSource = this.CustomersBinding;
            this.bookingCustomerComboBox.DisplayMember = "Display";
            this.bookingCustomerComboBox.SelectedItem = null;

            this.VehiclesBinding = new BindingSource();
            this.VehiclesBinding.DataSource = this.VehicleList;
            this.bookingVehicleComboBox.DataSource = this.VehiclesBinding;
            this.bookingVehicleComboBox.DisplayMember = "Display";
            this.bookingVehicleComboBox.SelectedItem = null;
        }

        public void RefreshVehiclesBinding()
        {
            this.VehicleList = this.DataService.GetVehiclesAsList();
            this.VehiclesBinding.DataSource = this.VehicleList;
            this.VehiclesBinding.ResetBindings(false);
        }

        public void RefreshCustomersBinding()
        {
            this.CustomerList = this.DataService.GetCustomersAsList();
            this.CustomersBinding.DataSource = this.CustomerList;
            this.CustomersBinding.ResetBindings(false);
        }

        private void RefreshBookingsBinding(DateTime filteredDate)
        {
            this.BookingList = this.DataService.GetBookingsAsList().Where(x => x.Date.Date == filteredDate).ToList();
            this.BookingList.Sort(new BookingRowSorter());

            this.BookingsBinding.DataSource = this.BookingList;
            this.BookingsBinding.ResetBindings(false);
        }

        private void RefreshBookingsBinding()
        {
            this.BookingList = this.DataService.GetBookingsAsList();
            this.BookingList.Sort(new BookingRowSorter());

            this.BookingsBinding.DataSource = this.BookingList;
            this.BookingsBinding.ResetBindings(false);
        }

        private void ResetBookingForm()
        {
            this.bookingDateTimePicker.ResetText();
            this.bookingStartTimePicker.ResetText();
            this.bookingEndTimePicker.ResetText();

            this.bookingNotesTextBox.ResetText();

            this.bookingCustomerComboBox.SelectedItem = null;
            this.bookingVehicleComboBox.SelectedItem = null;

            this.DisableAllErrorLabels();
        }

        private bool BookingTimeIsValid()
        {
            DateTime startTime = this.bookingStartTimePicker.Value;
            DateTime endTime = this.bookingEndTimePicker.Value;

            if ( (startTime.Hour >= endTime.Hour) && (startTime.Minute >= endTime.Minute) )
            {
                return false;
            }

            return true;
        }

        private bool CustomerInputIsValid()
        {
            var customer = this.bookingCustomerComboBox.SelectedItem;

            if (customer is null)
            {
                return false;
            }

            return true;
        }

        private bool VehicleInputIsValid()
        {
            var vehicle = this.bookingVehicleComboBox.SelectedItem;

            if (vehicle is null)
            {
                return false;
            }

            return true;
        }

        private bool NotesInputIsValid()
        {
            string notes = this.bookingNotesTextBox.Text;

            if (string.IsNullOrWhiteSpace(notes))
            {
                return false;
            }

            return true;
        }

        private void DisableAllErrorLabels()
        {
            this.endTimeErrorLabel.Visible = false;
            this.existingCustomersErrorLabel.Visible = false;
            this.existingVehiclesErrorLabel.Visible = false;
            this.notesErrorLabel.Visible = false;
        }

        private void ValidateBookingInputAndDisplayErrors()
        {
            this.BookingInputIsValid = true;

            this.DisableAllErrorLabels();

            if (! this.BookingTimeIsValid())
            {
                this.BookingInputIsValid = false;
                this.endTimeErrorLabel.Visible = true;
            }
            if (! this.CustomerInputIsValid())
            {
                this.BookingInputIsValid = false;
                this.existingCustomersErrorLabel.Visible = true;
            }
            if (! this.VehicleInputIsValid())
            {
                this.BookingInputIsValid = false;
                this.existingVehiclesErrorLabel.Visible = true;
            }
            if (! this.NotesInputIsValid())
            {
                this.BookingInputIsValid = false;
                this.notesErrorLabel.Visible = true;
            }
        }

        /* Classes */

        private class BookingRowSorter : IComparer<Booking>
        {
            public int Compare(Booking x, Booking y)
            {
                int comparison = x.Date.Date.CompareTo(y.Date.Date);

                if (comparison == 0)
                {
                    return x.StartTime.TimeOfDay.CompareTo(y.StartTime.TimeOfDay);
                }

                return comparison;
            }
        }

        /* Events */

        private void bookingsFilterDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime filteredDate = this.bookingsFilterDateTimePicker.Value.Date;

            this.RefreshBookingsBinding(filteredDate);
        }

        private void bookingsFilterComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.bookingsFilterComboBox.SelectedItem.Equals("Show All"))
            {
                this.RefreshBookingsBinding();
                this.bookingsFilterDateTimePicker.Enabled = false;
            }
            else if (this.bookingsFilterComboBox.SelectedItem.Equals("Date"))
            {
                this.bookingsFilterDateTimePicker.Enabled = true;
            }
        }

        private void bookingResetButton_Click(object sender, EventArgs e)
        {
            this.ResetBookingForm();
        }

        private void bookingNowButton_Click(object sender, EventArgs e)
        {
            this.ValidateBookingInputAndDisplayErrors();

            if (this.BookingInputIsValid)
            {
                DateTime date = this.bookingDateTimePicker.Value;
                Customer customer = (Customer)this.bookingCustomerComboBox.SelectedItem;
                Vehicle vehicle = (Vehicle)this.bookingVehicleComboBox.SelectedItem;
                DateTime startTime = this.bookingStartTimePicker.Value;
                DateTime endTime = this.bookingEndTimePicker.Value;
                string notes = this.bookingNotesTextBox.Text;

                Booking booking = new Booking()
                {
                    Date = date,
                    Customer = customer,
                    Vehicle = vehicle,
                    StartTime = startTime,
                    EndTime = endTime,
                    Notes = notes
                };

                this.DataService.SaveBooking(booking);

                this.RefreshBookingsBinding();
                this.ResetBookingForm();
            }
        }

        private void deleteBookingButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = this.bookingDataGridView.SelectedRows[0];

            string idString = selectedRow.Cells["id"].Value.ToString();

            int id = int.Parse(idString);

            this.DataService.DeleteBooking(id);

            if (this.bookingsFilterComboBox.Text == "Date")
            {
                DateTime filteredDate = this.bookingsFilterDateTimePicker.Value;
                this.RefreshBookingsBinding(filteredDate);
            }
            else
            {
                this.RefreshBookingsBinding();
            }

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            AddCustomerForm addCustomerForm = new AddCustomerForm(this);
            addCustomerForm.Show();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            AddVehicleForm addVehicleForm = new AddVehicleForm(this);
            addVehicleForm.Show();
        }
        
        // Update the bookings grid view with the last information when the user switches to the form
        private void BookingForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                // if the list is filtered by date, then only restrict the binding list to contain only that date
                if (this.bookingsFilterComboBox.Text == "Date")
                {
                    DateTime filteredDate = this.bookingsFilterDateTimePicker.Value.Date;
                    this.RefreshBookingsBinding(filteredDate);
                }
                else
                {
                    this.RefreshBookingsBinding();
                }

                // before refreshing the customer binding, check to see if there is a currently selected
                // customer, and set it to null if none is selected, because refreshing the binding
                // will automatically set a selected item
                var bookingCustomerSelectedItem = this.bookingCustomerComboBox.SelectedItem;
                this.RefreshCustomersBinding();
                if (bookingCustomerSelectedItem is null)
                {
                    this.bookingCustomerComboBox.SelectedItem = null;
                }

                // before refreshing the vehicle binding, check to see if there is a currently selected
                // vehicle, and set it to null if none is selected, because refreshing the binding
                // will automatically set a selected item
                var bookingVehicleSelectedItem = this.bookingVehicleComboBox.SelectedItem;
                this.RefreshVehiclesBinding();
                if (bookingVehicleSelectedItem is null)
                {
                    this.bookingVehicleComboBox.SelectedItem = null;
                }
            }

        }

        private void bookingsFilterDateTimePicker_EnabledChanged(object sender, EventArgs e)
        {
            if (this.bookingsFilterDateTimePicker.Enabled == true)
            {
                DateTime filteredDate = this.bookingsFilterDateTimePicker.Value.Date;

                this.RefreshBookingsBinding(filteredDate);
            }
        }

        private void bookingDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.bookingDataGridView.SelectedRows.Count == 0)
            {
                this.deleteBookingButton.Enabled = false;
            }
            else
            {
                this.deleteBookingButton.Enabled = true;
            }
            
        }
    }
}
