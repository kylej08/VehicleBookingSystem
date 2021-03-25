using System;

namespace VehicleBookingLibrary
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string DisplayCustomer => this.Customer.Display;
        public string DisplayVehicle => this.Vehicle.Display;
        public string DisplayDate => this.Date.ToString("dd/MM/yyyy");
        public string DisplayStartTime => this.StartTime.ToString("HH:mm");
        public string DisplayEndTime => this.EndTime.ToString("HH:mm");
    }
}
