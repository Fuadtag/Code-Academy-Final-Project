using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
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
        public IActionResult List()
        {
            ICollection<Car> cars = _context.Cars.Include("Model").Include("Model.CarBrand").ToList();
            return View(cars);
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {

            return View();
        }
    }
}