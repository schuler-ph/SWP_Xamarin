namespace SWP_Xamarin_Hotel_API.Models
{
    public class Bills_Rooms
    {
        public int Bills_RoomsId { get; set; }
        public Bill Bill { get; set; }
        public Room Room { get; set; }
        public float Discount { get; set; }
    }
}
