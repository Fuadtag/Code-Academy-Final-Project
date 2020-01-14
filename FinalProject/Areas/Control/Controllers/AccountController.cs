using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.Control.Controllers
{
    public class AccountController : Controller
    {
        private readonly RentNowContext _context;
        public AccountController(RentNowContext context)
        {
            _context = context;
        }
        public IActionResult Logout(string token)
        {
            var cookie = Request.Cookies["Token"];
            if (cookie == null)
            {
                return RedirectToAction("index", "Login");
            }
            Admin admin = _context.Admin.FirstOrDefault(a => a.Token == cookie);
            if (admin != null)
            {
                admin.Token = null;
                _context.SaveChanges();
            }

            return RedirectToAction("index", "home");
        }
    }
}
