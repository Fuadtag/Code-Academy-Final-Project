using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems{ get; set; }
        public Payment PaymentMethod { get; set; }
        [Required]
        [Column(TypeName ="Date")]
        public DateTime PickupDate { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime DropDate { get; set; }
        [Required]
        [MaxLength(200)]
        public string PickupLocation { get; set; }
        [Required]
        [MaxLength(200)]
        public string DropLocation { get; set; }
        [MaxLength(200)]
        public string OrderNote { get; set; }
        [Column(TypeName ="money")]
        public decimal Total { get; set; }

        public bool Status { get; set; }

    }
}
