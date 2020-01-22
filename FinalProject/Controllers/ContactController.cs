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
    public class ContactController : Controller
    {
        private readonly RentNowContext _context;
        public ContactController(RentNowContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Setting model = await _context.Settings.FirstOrDefaultAsync();
            return View(model);
        }
    }
}