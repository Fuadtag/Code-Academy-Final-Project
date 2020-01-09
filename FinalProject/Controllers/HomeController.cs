using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProject.Models;
using FinalProject.Data;
using FinalProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RentNowContext _context;
        public HomeController(RentNowContext context)
        {
            _context = context;
        }

       

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Advantages = _context.Advantage.ToList();
            model.Blogs = _context.Blogs.Include("Category").Include("Author").OrderByDescending(b => b.CreatedAt).Take(3).ToList();
            model.Sliders = _context.Sliders.Take(3).ToList();
            model.Cartypes = _context.CarTypes.ToList();
            model.Advantages = _context.Advantage.Take(8).ToList();
            model.Testimonials = _context.Testimonials.Take(4).ToList();
            return View(model);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
