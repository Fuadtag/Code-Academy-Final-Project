using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CustomerReview
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int CarId { get; set; }
        public Car Car { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "200")]
        public string Text { get; set; }
        public byte QualityStars { get; set; }
        public byte PriceStars { get; set; }
        public byte ComfortStars { get; set; }
        public byte DrivingStars { get; set; }
        public bool PositiveReview { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
