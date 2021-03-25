using System;
using System.Windows.Forms;

namespace VehicleBookingUI
{
    /*
     * Utilised a proposed solution for keeping one part of a form static, and another dynamic, changing its content depending on an action taken
     * Creator name - Reza Aghaei (https://stackoverflow.com/users/3110834/reza-aghaei)
       License - CC BY-SA 3.0 (https://creativecommons.org/licenses/by-sa/3.0/)
       Link to material - https://stackoverflow.com/a/36252030
     */
    public partial class NavigationForm : Form
    {
        private BookingForm BookingForm { get; set; }
        private ModifyCustomersForm ModifyCustomersForm { get; set; }
        private ModifyVehiclesForm ModifyVehiclesForm { get; set; }

        public NavigationForm()
        {
            InitializeComponent();

            this.BookingForm = new BookingForm();
            this.ModifyCustomersForm = new ModifyCustomersForm();
            this.ModifyVehiclesForm = new ModifyVehiclesForm();

            this.BookingForm.TopLevel = false;
            this.BookingForm.FormBorderStyle = FormBorderStyle.None;

            this.ModifyCustomersForm.TopLevel = false;
            this.ModifyCustomersForm.FormBorderStyle = FormBorderStyle.None;

            this.ModifyVehiclesForm.TopLevel = false;
            this.ModifyVehiclesForm.FormBorderStyle = FormBorderStyle.None;

            this.navigationSplitContainer.Panel2.Controls.Add(BookingForm);
            this.navigationSplitContainer.Panel2.Controls.Add(ModifyCustomersForm);
            this.navigationSplitContainer.Panel2.Controls.Add(ModifyVehiclesForm);
        }

        private void bookingFormButton_Click(object sender, EventArgs e)
        {
            this.ModifyCustomersForm.Hide();
            this.ModifyVehiclesForm.Hide();
            this.BookingForm.Show();
        }

        private void editFormButton_Click(object sender, EventArgs e)
        {
            this.BookingForm.Hide();
            this.ModifyVehiclesForm.Hide();
            this.ModifyCustomersForm.Show();
        }

        private void vehiclesFormButton_Click(object sender, EventArgs e)
        {
            this.BookingForm.Hide();
            this.ModifyCustomersForm.Hide();
            this.ModifyVehiclesForm.Show();
        }
    }
}
