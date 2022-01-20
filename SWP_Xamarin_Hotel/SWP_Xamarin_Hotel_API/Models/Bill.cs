namespace SWP_Xamarin_Hotel_API.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public Guest Guest { get; set; }
        public bool IsPaid { get; set; }

        public DateTime BeginReservation { get; set; }
        public DateTime EndReservation { get; set; }

        public DateTime DueDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
