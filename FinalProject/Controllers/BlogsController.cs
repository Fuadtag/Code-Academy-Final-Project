using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class BlogsController : Controller
    {
        private readonly RentNowContext _context;

        public BlogsController(RentNowContext context)
        {
            _context = context;
        }

        public IActionResult Blog(int? categoryid , int? tagid)
        {
            if (categoryid != null)
            {
                BlogViewModel searchbycategory = new BlogViewModel
                {
                    Tags = _context.Tags.ToList(),
                    Blogs = _context.Blogs.Include("Category").Include("Author").Where(b => b.BlogCategoryId == categoryid).ToList(),
                    Categories = _context.BlogCategories.ToList()

                };
            }
            
            BlogViewModel model = new BlogViewModel
            {
                Tags = _context.Tags.ToList(),
                Blogs = _context.Blogs.Include("Category").Include("Author").ToList(),
                Categories = _context.BlogCategories.ToList()

            };
            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var dbblog = _context.Blogs.FirstOrDefault(b => b.Id == id);
            if (dbblog != null)
            {
                dbblog.Visited += 1;

            }

            BlogViewModel model = new BlogViewModel
            {

                Blog = _context.Blogs.Include("BlogComments").Include("Category").Include("Author").FirstOrDefault(b => b.Id == id),
                Tags = _context.Tags.ToList(),
                Blogs = _context.Blogs.Include("Category").Include("Author").OrderByDescending(b => b.CreatedAt).Take(3).ToList(),
                
                
            };
            
            

            return View(model);
        }

        
    }
}