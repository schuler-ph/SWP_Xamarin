using System;

namespace SWP_Xamarin_Hotel.Models
{
    public class Bills_Rooms
    {
        public int Bills_RoomsId { get; set; }
        public Bill Bill { get; set; }
        public Room Room { get; set; }
        public DateTime BeginReservation { get; set; }
        public string BeginString => BeginReservation.ToShortDateString();
        public DateTime EndReservation { get; set; }
        public string EndString => EndReservation.ToShortDateString();
        public float Discount { get; set; }
    }
}
