using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_App1.Models
{
    // DTO ... Data Transfer Object - Klasse
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
    }
}
