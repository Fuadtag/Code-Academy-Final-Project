using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Team
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        [MaxLength]
        public string Photo { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Must not be more than 30 symbol")]
        public string Name { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Must not be more than 30 symbol")]

        public string Position { get; set; }
        [MaxLength(30, ErrorMessage = "Must not be more than 60 symbol")]

        public string FacebookLink { get; set; }
        [MaxLength(30, ErrorMessage = "Must not be more than 60 symbol")]

        public string TwitterLink { get; set; }
        [MaxLength(30, ErrorMessage = "Must not be more than 60 symbol")]
        public string InstagramLink { get; set; }
        [MaxLength(30, ErrorMessage = "Must not be more than 60 symbol")]
        public string LinkedInLink { get; set; }
    }
}
