using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string MainAdress { get; set; }
        public string Adress { get; set; }

        public string Postalcode { get; set; }

        public byte Age { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public bool HappyClient { get; set; }

    }
}
