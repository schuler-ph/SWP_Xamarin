namespace SWP_Xamarin_Hotel.Models
{
    public class Guests_Addresses
    {
        public int Guests_AddressesId { get; set; }
        public Guest Guest { get; set; }
        public Address Address { get; set; }
    }
}
