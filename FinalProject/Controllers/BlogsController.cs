﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}