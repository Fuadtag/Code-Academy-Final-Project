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
        [MaxLength(200, ErrorMessage = "Can not be more than 200 symbol")]
        public string Name { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Can not be more than 200 symbol")]
        public string Surname { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Can not be more than 200 symbol")]
        public string Email { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Can not be more than 200 symbol")]
        public string Password { get; set; }

        public string Token { get; set; }
        public Country Country { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Can not be more than 200 symbol")]
        public string StreetAdress { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Can not be more than 200 symbol")]

        public string Postalcode { get; set; }

        public byte Age { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<CustomerReview> CustomerReviews { get; set; }

        public bool HappyClient { get; set; }

    }
}
