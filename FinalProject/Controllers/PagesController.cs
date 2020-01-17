using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class PagesController : Controller
    {
        private readonly RentNowContext _context;
        public PagesController(RentNowContext context)
        {
            _context = context;
        }
        public IActionResult AboutUs()
        {
            AboutUsViewModel model = new AboutUsViewModel
            {
                Visions = _context.OurVisions.ToList(),
                Passion = _context.Passions.FirstOrDefault(),
                Teams = _context.Teams.ToList(),
                Partners = _context.Partners.ToList()
            };
            return View(model);
        }
        public IActionResult Page()
        {
            PageViewModel model = new PageViewModel
            {
                Page = _context.Pages.FirstOrDefault(),
                Tags = _context.Tags.ToList(),
                Blogs = _context.Blogs.Include("Category").OrderByDescending(b => b.CreatedAt).Take(3).ToList(),
                Categories = _context.BlogCategories.ToList()
            };
            return View(model);
        }
        public IActionResult Faq()
        {
            List<Faq> model = new List<Faq>();
            model = _context.Faqs.ToList();
            return View(model);
        }

        public IActionResult Gallery()
        {
            Gallery model = _context.Galleries.Include("GalleryItems").FirstOrDefault();
            return View(model);
        }

        public async Task<IActionResult> Cart()
        {
            var cookie = Request.Cookies["Token"];
            Customer customer = await _context.Customers.FirstOrDefaultAsync(c => c.Token == cookie);
            if (customer == null)
            {
                return RedirectToAction("Login", "Customers");
            }
            Order order = await _context.Orders.Include("Customer").Include("OrderIems").FirstOrDefaultAsync(o => o.CustomerId == customer.Id);

            return View(order);
            
        }

        public IActionResult Checkout(int? id)
        {
            if (id == null)
            {
                var token = Request.Cookies["Token"];
                Customer customer = _context.Customers.FirstOrDefault(c => c.Token == token);
                Order model = _context.Orders.Include("OrderItems").Include("OrderItems.Car").Include("OrderItems.Car.Model").FirstOrDefault(o => o.CustomerId == customer.Id);
                decimal total = 0;
                var days = (model.DropDate - model.PickupDate).Days;
                foreach (var item in model.OrderItems)
                {
                    total = item.Car.DailyPrice * days;
                }
                model.Total = total;
                _context.SaveChanges();
                return View(model);

            }
            Order order = _context.Orders.Include("OrderItems").Include("OrderItems.Car").FirstOrDefault(o => o.CustomerId == id);
            return View(order);
        }



        
    }
}