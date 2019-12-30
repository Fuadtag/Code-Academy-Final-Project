using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{

    public enum Payment
    {
        Cash,CreditCard
    }
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems{ get; set; }

        public Payment PaymentMethod { get; set; }

        public DateTime PickupDate { get; set; }
        public DateTime DropDate { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }

    }
}
