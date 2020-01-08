using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class BlogCommentReply
    {
        public int Id { get; set; }
        //public int BlogCommentId { get; set; }
        //public BlogComment BlogComment { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
