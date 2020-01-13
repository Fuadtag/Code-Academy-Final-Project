using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string FacebookLink { get; set; }

        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }

        public string GoogleLink { get; set; }

        public string LinkedInLink { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Must not be more than 30 symbol")]
        public string Phone{ get; set; }
        [MaxLength(200, ErrorMessage = "Must not be more than 30 symbol")]
        public string SupPhone { get; set; }
        [EmailAddress]
        
        public string Email { get; set; }
        [EmailAddress]
        public string SaleEmail { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Must not be more than 60 symbol")]
        public string MainAdress { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Must not be more than 60 symbol")]
        public string Adress { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Must not be more than 50 symbol")]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile FooterLogoFile { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Must not be more than 70 symbol")]
        public string FooterLogo { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Must not be more than 100 symbol")]
        public string FooterText { get; set; }
        [NotMapped]
        public IFormFile Payments { get; set; }
       
        [MaxLength(200, ErrorMessage = "Must not be more than 70 symbol")]
        public string Payment { get; set; }




    }
}
