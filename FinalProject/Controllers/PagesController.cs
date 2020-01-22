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
        public async Task<IActionResult> AboutUs()
        {
            AboutUsViewModel model = new AboutUsViewModel
            {
                Visions = await _context.OurVisions.ToListAsync(),
                Passion = await _context.Passions.FirstOrDefaultAsync(),
                Teams = await _context.Teams.ToListAsync(),
                Partners = await _context.Partners.ToListAsync()
            };
            return View(model);
        }
        public async Task<IActionResult> Page()
        {
            PageViewModel model = new PageViewModel
            {
                Page = await _context.Pages.FirstOrDefaultAsync(),
                Tags = await _context.Tags.ToListAsync(),
                Blogs = await _context.Blogs.Include("Category").OrderByDescending(b => b.CreatedAt).Take(3).ToListAsync(),
                Categories = await _context.BlogCategories.ToListAsync()
            };
            return View(model);
        }
        public async Task<IActionResult> Faq()
        {
            List<Faq> model = new List<Faq>();
            model = await _context.Faqs.ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> Gallery()
        {
            Gallery model = await _context.Galleries.Include("GalleryItems").FirstOrDefaultAsync();
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

        public async Task<IActionResult> Checkout(int? id)
        {
            if (id == null)
            {
                var token = Request.Cookies["Token"];
                
                if (token == null)
                {
                    return RedirectToAction("Login", "Customers");
                }
                Customer customer = await _context.Customers.FirstOrDefaultAsync(c => c.Token == token);
                Order model = await _context.Orders.Include("OrderItems").Include("OrderItems.Car").Include("OrderItems.Car.Model").Where(a => a.Status == true).FirstOrDefaultAsync(o => o.CustomerId == customer.Id);
                if (model == null)
                {
                    return RedirectToAction("List", "Cars");
                }
                decimal total = 0;
                var days = (model.DropDate - model.PickupDate).Days;
                foreach (var item in model.OrderItems)
                {
                    total = item.Car.DailyPrice * days;
                }
                model.Total = total;
                await _context.SaveChangesAsync();
                return View(model);

            }
            Order order = await _context.Orders.Include("OrderItems").Include("OrderItems.Car").FirstOrDefaultAsync(o => o.CustomerId == id);
            return View(order);
        }



        
    }
}