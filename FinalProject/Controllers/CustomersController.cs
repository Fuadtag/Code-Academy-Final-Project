using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject.Controllers
{
    public class CustomersController : Controller
    {
        private readonly RentNowContext _context;

        public CustomersController(RentNowContext context)
        {
            _context = context;
        }

        [HttpGet]
       public async Task<IActionResult> Login()
        {
            var token = Request.Cookies["Token"];
            if (token != null)
            {
                Customer loginedcustomer = await _context.Customers.FirstOrDefaultAsync(c => c.Token == token);
                if (loginedcustomer != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            Customer customer = new Customer();

            return View(customer);
        }

        [HttpPost]

        public async Task<IActionResult> Login(Customer customer)
        {
            if (!string.IsNullOrEmpty(customer.Email) && !string.IsNullOrEmpty(customer.Password))
            {
                Customer lgncustomer = await _context.Customers.FirstOrDefaultAsync(c => c.Email == customer.Email);
                PasswordHasher<Customer> hasher = new PasswordHasher<Customer>(
                       new OptionsWrapper<PasswordHasherOptions>(
                           new PasswordHasherOptions()
                           {
                               CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
                           })
                   );
                var result = hasher.VerifyHashedPassword(lgncustomer, lgncustomer.Password, customer.Password);
                if (lgncustomer != null && result == PasswordVerificationResult.Success)
                {
                    lgncustomer.Token = Guid.NewGuid().ToString();
                    await _context.SaveChangesAsync();
                    var option = new CookieOptions
                    {
                        Expires = DateTime.Now.AddHours(1),
                        IsEssential = true

                    };
                    Response.Cookies.Append("Token", lgncustomer.Token, option);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(customer);


        }

        // GET: Customers/Create
        [HttpGet]
        public IActionResult Create()

        {
            var token = Request.Cookies["Token"];
            if (token != null)
            {
                return RedirectToAction("Index", "Home");
            }

            Customer customer = new Customer();
            return View(customer);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Email,Password,Country,StreetAdress,Postalcode,Age")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                PasswordHasher<Customer> hasher = new PasswordHasher<Customer>(
                       new OptionsWrapper<PasswordHasherOptions>(
                           new PasswordHasherOptions()
                           {
                               CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
                           })
                   );
                customer.Password = hasher.HashPassword(customer, customer.Password);
                customer.Token = Guid.NewGuid().ToString();
                customer.HappyClient = false;
                await _context.Customers.AddAsync(customer);
                await _context.SaveChangesAsync();
                var option = new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(60),
                    IsEssential = true

                };
                Response.Cookies.Append("Token", customer.Token, option);
                return RedirectToAction("Index", "Home");
            }
            return View(customer);
        }

        public IActionResult Logout()
        {
            var token = Request.Cookies["Token"];
            if (token != null)
            {
                var customer = _context.Customers.FirstOrDefault(c => c.Token == token);
                Response.Cookies.Delete("Token");
                customer.Token = null;
                _context.SaveChanges();

            }
            return RedirectToAction("Index", "Home");
        }
        

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        

        

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
