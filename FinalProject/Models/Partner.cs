using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Partner
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        [MaxLength(200)]
        public string Photo { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage ="Must not be more than 30 symbol")]
        public string Name { get; set; }

    }
}
