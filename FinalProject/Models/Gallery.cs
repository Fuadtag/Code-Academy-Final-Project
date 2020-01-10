using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public ICollection<GalleryItem> GalleryItems { get; set; }
    }
}
