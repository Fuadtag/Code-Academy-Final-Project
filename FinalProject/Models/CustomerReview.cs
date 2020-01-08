using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CustomerReview
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string Text { get; set; }
        public byte QualityStars { get; set; }
        public byte PriceStars { get; set; }
        public byte ComfortStars { get; set; }
        public byte DrivingStars { get; set; }
        public bool PositiveReview { get; set; }

        
    }
}
