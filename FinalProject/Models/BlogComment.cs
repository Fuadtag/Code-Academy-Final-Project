using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class BlogComment
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public DateTime CreatedAt { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [Required]
        [MaxLength(150)]
        public string Text { get; set; }


    }
}
