using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FinalProject.Controllers
{
    public class LoginController : Controller
    {

        private readonly RentNowContext _context;
        public LoginController(RentNowContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var cookieval = Request.Cookies["Token"];
            if (cookieval != null)
            {
                Admin admin1 = _context.Admin.FirstOrDefault(a => a.Token == cookieval);
                if (admin1 != null)
                {
                    return LocalRedirect("/control");
                }
            }
            Admin admin = new Admin();
            return View(admin);
        }
        [HttpPost]
        public IActionResult Index(Admin admin)
        {
            if (ModelState.IsValid)
            {
                Admin dbadmin = _context.Admin.FirstOrDefault(a => a.Email == admin.Email);
                PasswordHasher<Admin> hasher = new PasswordHasher<Admin>(
                       new OptionsWrapper<PasswordHasherOptions>(
                           new PasswordHasherOptions()
                           {
                               CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
                           })
                   );
                var result = hasher.VerifyHashedPassword(dbadmin, dbadmin.Password, admin.Password);
                if (result == PasswordVerificationResult.Success && dbadmin !=null)
                {
                    admin.Token = Guid.NewGuid().ToString();
                    _context.SaveChanges();
                    var cookiex = new CookieOptions
                    {
                        Expires = DateTime.Now.AddHours(1),
                        IsEssential = true

                    };
                    Response.Cookies.Append("Token", admin.Token, cookiex);
                    return LocalRedirect("/control");
                }
            }
            
            return View(admin);
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

            return LocalRedirect("");
        }
    }
}