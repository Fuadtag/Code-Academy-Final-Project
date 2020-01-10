using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly RentNowContext _context;
        public ServiceController(RentNowContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServiceViewModel model = new ServiceViewModel
            {
                Testimonials = _context.Testimonials.ToList(),
                Offers = _context.Offers.ToList()
            };
            return View(model);
        }
    }
}