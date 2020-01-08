using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class SliderItem
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }

        public string Photo { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
