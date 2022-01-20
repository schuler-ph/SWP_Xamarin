using System.ComponentModel.DataAnnotations;

namespace SWP_Xamarin_Hotel_API.Models
{
    public class Guest
    { 
        [Key]
        public string PassportNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
