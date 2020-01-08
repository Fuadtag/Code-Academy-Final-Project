using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        public string Photo { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
