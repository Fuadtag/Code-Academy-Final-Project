﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.Control.Controllers
{
    [Authorize]
    [Area("Control")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}