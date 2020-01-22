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

       

        public async Task<IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Advantages = await _context.Advantage.ToListAsync();
            model.Blogs = await _context.Blogs.Include("Category").Include("Author").OrderByDescending(b => b.CreatedAt).Take(3).ToListAsync();
            model.Sliders = await _context.Sliders.Take(3).ToListAsync();
            model.Cartypes = await _context.CarTypes.ToListAsync();
            model.Advantages = await _context.Advantage.Take(8).ToListAsync();
            model.Testimonials = await _context.Testimonials.Take(4).ToListAsync();
            model.Cars = await _context.Cars.Include("Model").Include("Model.CarBrand").Where(c => c.Status == true).Take(6).ToListAsync();


           
            return View(model);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
