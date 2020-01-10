using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName ="ntext")]
        public string TopText { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        [Required]
        [MaxLength(30)]
        public string InfoText { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoSmFile { get; set; }
        public string PhotoSm { get; set; }
        [Required]
        [MaxLength(50)]
        public string Slug { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public List<Tag> Tags { get; set; }
        [Required]
        [Column(TypeName ="date")]
        public DateTime CreatedAt { get; set; }

        public int Likes { get; set; }

        public int Visited { get; set; }

        public int BlogCategoryId { get; set; }
        public BlogCategory Category { get; set; }

        public List<BlogComment> BlogComments { get; set; }

        //public List<BlogCommentReply> Replies { get; set; }


    }
}
