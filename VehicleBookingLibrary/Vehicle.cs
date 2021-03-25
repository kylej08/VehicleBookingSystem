
namespace VehicleBookingLibrary
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string RegistrationNumber { get; set; }
        public string Display => $"{ this.Model } { this.Make } - { this.RegistrationNumber }";
    }
}
