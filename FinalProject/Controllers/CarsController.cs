using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}