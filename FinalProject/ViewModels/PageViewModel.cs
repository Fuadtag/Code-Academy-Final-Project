using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class PageViewModel
    {
        public Page Page { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public ICollection<Blog> Blogs { get; set; }

        public ICollection<BlogCategory> Categories { get; set; }
    }
}
