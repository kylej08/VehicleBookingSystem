
namespace VehicleBookingLibrary
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Display => $"{ this.FirstName } { this.LastName } - { this.ContactNumber }";

    }
}
