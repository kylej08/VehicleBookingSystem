using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleBookingLibrary;

namespace VehicleBookingUI
{
    public partial class ModifyVehiclesForm : Form
    {
        private DataService DataService { get; set; }
        private List<Vehicle> VehicleList { get; set; }
        private BindingSource VehiclesBinding { get; set; }
        private bool VehicleInputIsValid { get; set; }

        public ModifyVehiclesForm()
        {
            InitializeComponent();

            this.DataService = DataService.GetDataService();

            SetupCustomerGridView();
            PopulateVehicleList();
            SetupBindings();
            EditButtonStates(false, false);
        }

        private void SetupCustomerGridView()
        {
            this.vehicleDataGridView.AutoGenerateColumns = false;


            DataGridViewColumn idColumn = this.CreateDataGridColumn("Id", "Id");
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.vehicleDataGridView.Columns.Add(idColumn);

            DataGridViewColumn modelColumn = this.CreateDataGridColumn("Model", "Model");
            this.vehicleDataGridView.Columns.Add(modelColumn);

            DataGridViewColumn makeColumn = this.CreateDataGridColumn("Make", "Make");
            this.vehicleDataGridView.Columns.Add(makeColumn);

            DataGridViewColumn registrationNumberColumn = this.CreateDataGridColumn("Registration Number", "RegistrationNumber");
            this.vehicleDataGridView.Columns.Add(registrationNumberColumn);
        }

        private void PopulateVehicleList()
        {
            this.VehicleList = this.DataService.GetVehiclesAsList();
        }

        private void SetupBindings()
        {
            this.VehiclesBinding = new BindingSource();
            this.VehiclesBinding.DataSource = this.VehicleList;
            this.vehicleDataGridView.DataSource = this.VehiclesBinding;
        }

        private void EditButtonStates(bool editButtonEnabled, bool saveButtonEnabled)
        {
            this.editButton.Enabled = editButtonEnabled;
            this.saveButton.Enabled = saveButtonEnabled;
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
            this.modelTextBox.Enabled = false;
            this.makeTextBox.Enabled = false;
            this.registrationNumberTextBox.Enabled = false;
        }

        private void UnlockTextBoxes()
        {
            this.modelTextBox.Enabled = true;
            this.makeTextBox.Enabled = true;
            this.registrationNumberTextBox.Enabled = true;
        }

        private void HideErrorLabels()
        {
            this.modelErrorLabel.Visible = false;
            this.makeErrorLabel.Visible = false;
            this.registrationNumberErrorLabel.Visible = false;
        }

        private void RefreshVehiclesBinding()
        {
            this.VehicleList = this.DataService.GetVehiclesAsList();
            this.VehicleList.Sort(new VehicleRowSorter());
            this.VehiclesBinding.DataSource = this.VehicleList;
            this.VehiclesBinding.ResetBindings(false);
        }

        private void ValidateCustomerInputAndDisplayErrors()
        {
            this.VehicleInputIsValid = true;

            if (! ModelInputIsValid())
            {
                this.modelErrorLabel.Visible = true;
                this.VehicleInputIsValid = false;
            }
            if (! MakeInputIsValid())
            {
                this.makeErrorLabel.Visible = true;
                this.VehicleInputIsValid = false;
            }
            if (! RegistrationNumberInputIsValid())
            {
                this.registrationNumberErrorLabel.Visible = true;
                this.VehicleInputIsValid = false;
            }
        }

        private bool ModelInputIsValid()
        {
            string model = this.modelTextBox.Text;

            if (string.IsNullOrWhiteSpace(model) || this.ContainsDigits(model))
            {
                return false;
            }

            return true;
        }

        private bool MakeInputIsValid()
        {
            string make = this.makeTextBox.Text;

            if (string.IsNullOrWhiteSpace(make))
            {
                return false;
            }

            return true;
        }

        private bool RegistrationNumberInputIsValid()
        {
            string registrationNumber = this.registrationNumberTextBox.Text;

            if (string.IsNullOrWhiteSpace(registrationNumber))
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

        /* Classes */

        private class VehicleRowSorter : IComparer<Vehicle>
        {
            public int Compare(Vehicle x, Vehicle y)
            {
                return x.Id.CompareTo(y.Id);
            }
        }

        /* Events */

        private void vehicleDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.EditButtonStates(true, false);

            this.LockTextBoxes();

            DataGridViewSelectedRowCollection rows = this.vehicleDataGridView.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                this.idTextBox.Text = row.Cells["Id"].Value.ToString();
                this.modelTextBox.Text = row.Cells["Model"].Value.ToString();
                this.makeTextBox.Text = row.Cells["Make"].Value.ToString();
                this.registrationNumberTextBox.Text = row.Cells["Registration Number"].Value.ToString();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.UnlockTextBoxes();
            this.EditButtonStates(false, true);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (this.vehicleDataGridView.RowCount == 0)
            {
                return;
            }

            this.EditButtonStates(true, false);

            this.LockTextBoxes();
            this.HideErrorLabels();

            DataGridViewSelectedRowCollection rows = this.vehicleDataGridView.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                this.idTextBox.Text = row.Cells["Id"].Value.ToString();
                this.modelTextBox.Text = row.Cells["Model"].Value.ToString();
                this.makeTextBox.Text = row.Cells["Make"].Value.ToString();
                this.registrationNumberTextBox.Text = row.Cells["Registration Number"].Value.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.ValidateCustomerInputAndDisplayErrors();

            if (this.VehicleInputIsValid)
            {
                this.HideErrorLabels();

                int id = int.Parse(this.idTextBox.Text);
                string model = this.modelTextBox.Text;
                string make = this.makeTextBox.Text;
                string registrationNumber = this.registrationNumberTextBox.Text;

                Vehicle vehicle = new Vehicle()
                {
                    Id = id,
                    Model = model,
                    Make = make,
                    RegistrationNumber = registrationNumber
                };

                this.EditButtonStates(true, false);
                this.LockTextBoxes();

                this.DataService.UpdateVehicle(vehicle);

                this.RefreshVehiclesBinding();
            }
        }

        private void ModifyVehiclesForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                this.RefreshVehiclesBinding();
            }
        }
    }
}
