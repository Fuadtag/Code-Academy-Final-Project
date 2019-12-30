using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Page()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
    }
}