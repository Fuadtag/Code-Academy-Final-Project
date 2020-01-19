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
    public class CarsController : Controller
    {

        private readonly RentNowContext _context;

        public CarsController(RentNowContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> List(int p = 1)
        {
            
            int pagesize = 6;

            ICollection<Car> cars = await _context.Cars.Include("Model").Include("Model.CarBrand").Where(c => c.Status == true).Skip((p - 1)* pagesize).Take(pagesize).ToListAsync();
            decimal pagecount = Math.Ceiling((decimal)(cars.Count / pagesize));
            ViewData["Pagecount"] = pagecount;
            return View(cars);
        }

        public IActionResult Search(string brand, string model)
        {
            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            Car car = await _context.Cars.Include("CustomerReviews").Include("CustomerReviews.Customer").Include("Model").Include("Model.CarBrand").FirstOrDefaultAsync(c => c.Id == id);
            if (car == null)
            {
                
                return NotFound();
            }
            CarDetailViewModel model = new CarDetailViewModel
            {
                Car = car,
                Order = new Order()

            };
            return View(model);
        }
    }
}