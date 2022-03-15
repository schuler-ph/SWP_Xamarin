using System;

namespace SWP_Xamarin_Hotel.Models
{
    public class Guest
    {
        public string PassportNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }

        public Guest(string passport, string fn, string ln, DateTime bday)
        {
            this.PassportNumber = passport;
            this.Firstname = fn;
            this.Lastname = ln;
            this.Birthday = bday;
        }
    }
}
