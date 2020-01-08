using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public enum Country
    {
        Azerbaijan,Georgia,Turkey,Russia
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Country Country { get; set; }
        public string StreetAdress { get; set; }

        public string Postalcode { get; set; }

        public byte Age { get; set; }

        public ICollection<Order> Orders { get; set; }

        public bool HappyClient { get; set; }

    }
}
