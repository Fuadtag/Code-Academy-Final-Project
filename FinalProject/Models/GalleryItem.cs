using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class GalleryItem
    {
        public int Id { get; set; }
        [Required]
        public int GalleryId { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoSmFile { get; set; }
        public string PhotoSm { get; set; }

    }
}
