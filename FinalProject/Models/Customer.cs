using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [MaxLength(50, ErrorMessage ="Can not be more than 50 symbol")]
        public string Name { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Can not be more than 50 symbol")]
        public string Surname { get; set; }
        [Required]
        [MaxLength(70, ErrorMessage = "Can not be more than 70 symbol")]
        public string Email { get; set; }
        [Required]
        [MaxLength(80, ErrorMessage = "Can not be more than 80 symbol")]
        public string Password { get; set; }
        public Country Country { get; set; }
        [Required]
        [MaxLength(70, ErrorMessage = "Can not be more than 70 symbol")]
        public string StreetAdress { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "Can not be more than 15 symbol")]

        public string Postalcode { get; set; }

        public byte Age { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<CustomerReview> CustomerReviews { get; set; }

        public bool HappyClient { get; set; }

    }
}
