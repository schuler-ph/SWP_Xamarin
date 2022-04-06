using System;

namespace SWP_Xamarin_Hotel.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public Guest Guest { get; set; }
        public bool IsPaid { get; set; }

        public DateTime DueDate { get; set; }
        public string DueDateString => DueDate.ToShortDateString();
        public PaymentMethod PaymentMethod { get; set; }
    }
}
