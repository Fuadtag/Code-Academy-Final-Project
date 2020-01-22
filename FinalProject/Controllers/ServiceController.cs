using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly RentNowContext _context;
        public ServiceController(RentNowContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ServiceViewModel model = new ServiceViewModel
            {
                Testimonials = await _context.Testimonials.Take(3).ToListAsync(),
                Offers = await _context.Offers.Take(6).ToListAsync()
            };
            return View(model);
        }
    }
}