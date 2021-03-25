using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleBookingLibrary;

namespace VehicleBookingUI
{
    public partial class ModifyCustomersForm : Form
    {
        private DataService DataService { get; set; }
        private List<Customer> CustomerList { get; set; }
        private BindingSource CustomersBinding { get; set; }
        private bool CustomerInputIsValid { get; set; }

        public ModifyCustomersForm()
        {
            InitializeComponent();

            this.DataService = DataService.GetDataService();

            SetupCustomerGridView();
            PopulateCustomerList();
            SetupBindings();
            EditButtonStates(false, false);
        }

        private void SetupBindings()
        {
            this.CustomersBinding = new BindingSource();
            this.CustomersBinding.DataSource = this.CustomerList;
            this.customerDataGridView.DataSource = this.CustomersBinding;
        }

        private void PopulateCustomerList()
        {
            this.CustomerList = this.DataService.GetCustomersAsList();
        }

        private void SetupCustomerGridView()
        {
            this.customerDataGridView.AutoGenerateColumns = false;

            DataGridViewColumn idColumn = this.CreateDataGridColumn("Id", "Id");
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.customerDataGridView.Columns.Add(idColumn);

            DataGridViewColumn firstNameColumn = this.CreateDataGridColumn("First Name", "FirstName");
            this.customerDataGridView.Columns.Add(firstNameColumn);

            DataGridViewColumn lastNameColumn = this.CreateDataGridColumn("Last Name", "LastName");
            this.customerDataGridView.Columns.Add(lastNameColumn);

            DataGridViewColumn contactNumberColumn = this.CreateDataGridColumn("Contact Number", "ContactNumber");
            this.customerDataGridView.Columns.Add(contactNumberColumn);
        }

        private DataGridViewTextBoxColumn CreateDataGridColumn(string columnName, string dataPropertyName)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = columnName;
            column.DataPropertyName = dataPropertyName;

            return column;
        }

        private void LockTextBoxes()
        {
            this.firstNameTextBox.Enabled = false;
            this.lastNameTextBox.Enabled = false;
            this.contactNumberTextBox.Enabled = false;
        }

        private void UnlockTextBoxes()
        {
            this.firstNameTextBox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.contactNumberTextBox.Enabled = true;
        }

        private void HideErrorLabels()
        {
            this.firstNameErrorLabel.Visible = false;
            this.lastNameErrorLabel.Visible = false;
            this.contactNumberErrorLabel.Visible = false;
        }

        private void EditButtonStates(bool editButtonEnabled, bool saveButtonEnabled)
        {
            this.editButton.Enabled = editButtonEnabled;
            this.saveButton.Enabled = saveButtonEnabled;
        }

        private void RefreshCustomersBinding()
        {
            this.CustomerList = this.DataService.GetCustomersAsList();
            this.CustomerList.Sort(new CustomerRowSorter());

            this.CustomersBinding.DataSource = this.CustomerList;
            this.CustomersBinding.ResetBindings(false);
        }

        private void ValidateCustomerInputAndDisplayErrors()
        {
            this.CustomerInputIsValid = true;

            if (! FirstNameInputIsValid())
            {
                this.firstNameErrorLabel.Visible = true;
                this.CustomerInputIsValid = false;
            }
            if (! LastNameInputIsValid())
            {
                this.lastNameErrorLabel.Visible = true;
                this.CustomerInputIsValid = false;
            }
            if (! ContactNumberInputIsValid())
            {
                this.contactNumberErrorLabel.Visible = true;
                this.CustomerInputIsValid = false;
            }
        }

        private bool FirstNameInputIsValid()
        {
            string firstName = this.firstNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || this.ContainsDigits(firstName))
            {
                return false;
            }

            return true;
        }

        private bool LastNameInputIsValid()
        {
            string lastName = this.lastNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(lastName) || this.ContainsDigits(lastName))
            {
                return false;
            }

            return true;
        }

        private bool ContactNumberInputIsValid()
        {
            string contactNumber = this.contactNumberTextBox.Text;

            if (string.IsNullOrWhiteSpace(contactNumber) || ContainsCharacters(contactNumber))
            {
                return false;
            }

            return true;
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


        /* Classes */

        private class CustomerRowSorter : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return x.Id.CompareTo(y.Id);
            }
        }

        /* Events */

        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.EditButtonStates(true, false);

            this.LockTextBoxes();

            DataGridViewSelectedRowCollection rows = this.customerDataGridView.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                this.idTextBox.Text = row.Cells["Id"].Value.ToString();
                this.firstNameTextBox.Text = row.Cells["First Name"].Value.ToString();
                this.lastNameTextBox.Text = row.Cells["Last Name"].Value.ToString();
                this.contactNumberTextBox.Text = row.Cells["Contact Number"].Value.ToString();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.UnlockTextBoxes();
            this.EditButtonStates(false, true);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (this.customerDataGridView.RowCount == 0)
            {
                return;
            }

            this.EditButtonStates(true, false);

            this.LockTextBoxes();
            this.HideErrorLabels();

            DataGridViewSelectedRowCollection rows = this.customerDataGridView.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                this.idTextBox.Text = row.Cells["Id"].Value.ToString();
                this.firstNameTextBox.Text = row.Cells["First Name"].Value.ToString();
                this.lastNameTextBox.Text = row.Cells["Last Name"].Value.ToString();
                this.contactNumberTextBox.Text = row.Cells["Contact Number"].Value.ToString();
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.ValidateCustomerInputAndDisplayErrors();

            if (this.CustomerInputIsValid)
            {
                this.HideErrorLabels();

                int id = int.Parse(this.idTextBox.Text);
                string firstName = this.firstNameTextBox.Text;
                string lastName = this.lastNameTextBox.Text;
                string contactNumber = this.contactNumberTextBox.Text;

                Customer customer = new Customer()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    ContactNumber = contactNumber
                };

                this.EditButtonStates(true, false);
                this.LockTextBoxes();

                this.DataService.UpdateCustomer(customer);

                this.RefreshCustomersBinding();
            }

        }

        private void ModifyCustomersForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                this.RefreshCustomersBinding();
            }
        }
    }
}
