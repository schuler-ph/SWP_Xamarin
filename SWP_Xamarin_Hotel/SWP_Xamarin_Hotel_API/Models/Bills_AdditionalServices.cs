namespace SWP_Xamarin_Hotel_API.Models
{
    public class Bills_AdditionalServices
    {
        public int Bills_AdditionalServicesId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Discount { get; set; }
        public Guest Guest { get; set; }
        public Bill Bill { get; set; }
        public AdditionalService AdditionalService { get; set; }
    }
}
