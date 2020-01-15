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

        public async Task<IActionResult> Blog(int? categoryid , int? tagid, int p =1)
        {

            int pagesize = 3;
            if (categoryid != null)
            {

                BlogViewModel searchbycategory = new BlogViewModel
                {
                    Tags = await _context.Tags.ToListAsync(),
                    Blogs = await _context.Blogs.Include("Category").Include("Author").Where(b => b.BlogCategoryId == categoryid).Skip((p - 1) * pagesize).Take(pagesize).ToListAsync(),
                    Categories = await _context.BlogCategories.ToListAsync()
                    

                };
                return View(searchbycategory);
            }
            
            BlogViewModel model = new BlogViewModel
            {
                Tags = await _context.Tags.ToListAsync(),
                Blogs = await _context.Blogs.Include("Category").Include("Author").Skip((p - 1) * pagesize).Take(pagesize).ToListAsync(),
                Categories = await _context.BlogCategories.ToListAsync()

            };

            decimal pagecount = Math.Ceiling((decimal)(model.Blogs.Count / pagesize));
            ViewData["Pagecount"] = pagecount;
            return View(model);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var dbblog = await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
            if (dbblog != null)
            {
                dbblog.Visited += 1;
                _context.SaveChanges();

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