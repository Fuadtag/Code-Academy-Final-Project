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
    public class PagesController : Controller
    {
        private readonly RentNowContext _context;
        public PagesController(RentNowContext context)
        {
            _context = context;
        }
        public IActionResult AboutUs()
        {
            AboutUsViewModel model = new AboutUsViewModel
            {
                Visions = _context.OurVisions.ToList(),
                Passion = _context.Passions.FirstOrDefault(),
                Teams = _context.Teams.ToList(),
                Partners = _context.Partners.ToList()
            };
            return View(model);
        }
        public IActionResult Page()
        {
            PageViewModel model = new PageViewModel
            {
                Page = _context.Pages.FirstOrDefault(),
                Tags = _context.Tags.ToList(),
                Blogs = _context.Blogs.Include("Category").OrderByDescending(b => b.CreatedAt).Take(3).ToList(),
                Categories = _context.BlogCategories.ToList()
            };
            return View(model);
        }
        public IActionResult Faq()
        {
            List<Faq> model = new List<Faq>();
            model = _context.Faqs.ToList();
            return View(model);
        }

        public IActionResult Gallery()
        {
            Gallery model = _context.Galleries.Include("GalleryItems").FirstOrDefault();
            return View(model);
        }

        public IActionResult Checkout()
        {
            
            return View();
        }
    }
}