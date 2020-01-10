using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        [NotMapped]
        public IFormFile PhotoFile{ get; set; }
        public string Photo { get; set; }

    }
}
