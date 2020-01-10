using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80, ErrorMessage = "Must not be more than 80 symbol")]
        public string Text { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Must not be more than 20 symbol")]
        public string Name { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Must not be more than 20 symbol")]
        public string Position { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Must not be more than 20 symbol")]
        public string Company { get; set; }
        [NotMapped]
        public IFormFile PhotoFile{ get; set; }
        [MaxLength(70)]
        public string Photo { get; set; }

    }
}
