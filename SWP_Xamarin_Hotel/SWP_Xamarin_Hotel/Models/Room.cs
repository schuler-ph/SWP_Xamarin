namespace SWP_Xamarin_Hotel.Models
{
    public class Room
    {
        public int RoomId { get; set; }

        public string RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public bool HasKitchen { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasTerrace { get; set; }
        public decimal PricePerNight { get; set; }

    }
}
