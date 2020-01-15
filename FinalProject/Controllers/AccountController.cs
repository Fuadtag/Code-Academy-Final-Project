using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<AppAdmin> userManager;
        private readonly SignInManager<AppAdmin> signInManager;
        public AccountController(UserManager<AppAdmin> userManager, SignInManager<AppAdmin> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [Authorize]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register() => View();

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Admin admin)
        {
            if (ModelState.IsValid)
            {
                AppAdmin appAdmin = new AppAdmin()
                {
                    UserName = admin.Username,
                    Email = admin.Email,
                };

                IdentityResult result = await userManager.CreateAsync(appAdmin, admin.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(admin);

        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            Login login = new Login();
            return View(login);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                AppAdmin appAdmin = await userManager.FindByEmailAsync(login.Email);
                
                if (appAdmin != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appAdmin, login.Password, false, false);
                    if (result.Succeeded)

                    {
                        return LocalRedirect("/Control");
                    }
                    ModelState.AddModelError("", "Wrong email or password");
                }
            }
            return View(login);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
    

   
}