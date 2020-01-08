using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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

        public string Phone{ get; set; }

        public string SupPhone { get; set; }

        public string Email { get; set; }
        public string SaleEmail { get; set; }
        public string MainAdress { get; set; }
        public string Adress { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile FooterLogoFile { get; set; }

        public string FooterLogo { get; set; }

        public string FooterText { get; set; }
        [NotMapped]
        public IFormFile Payments { get; set; }

        public string Payment { get; set; }




    }
}
