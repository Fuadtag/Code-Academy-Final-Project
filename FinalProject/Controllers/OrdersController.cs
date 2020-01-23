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
    public class OrdersController : Controller
    {
        private readonly RentNowContext _context;
        public OrdersController(RentNowContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Create(Order order, int carid)
        {
            var token = Request.Cookies["Token"];
            if (token == null)
            {
                ViewData["Requires Login"] = "Must be logined to create order";
                return RedirectToAction("Login", "Customers");
            }
            Customer customer = await _context.Customers.FirstOrDefaultAsync(c => c.Token == token);
            if (customer != null)
            {

                if (!string.IsNullOrEmpty(order.PickupLocation) && !string.IsNullOrEmpty(order.DropLocation))
                {
                    Order neworder = new Order
                    {

                        CustomerId = customer.Id,
                        Total = 0,
                        PickupLocation = order.PickupLocation,
                        PickupDate = order.PickupDate,
                        DropLocation = order.DropLocation,
                        DropDate = order.DropDate,
                        Status = true

                    };
                    await _context.Orders.AddAsync(neworder);
                    await _context.SaveChangesAsync();
                    OrderItem orderItem = new OrderItem
                    {
                        CarId = carid,
                        OrderId = neworder.Id,
                        Status = true


                    };
                    Car car = await _context.Cars.FirstOrDefaultAsync(c => c.Id == carid);
                    car.Status = false;
                    await _context.OrderItems.AddAsync(orderItem);
                    await _context.SaveChangesAsync();
                };
                return RedirectToAction("Detail", "Cars", new { id = carid });
                
            }
            return RedirectToAction("Checkout", "Pages", new {id = customer.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            Order order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order != null)
            {
                var item =  _context.OrderItems.Include("Car").Where(o => o.OrderId == order.Id);
                foreach (var oitem in item)
                {
                    oitem.Car.Status = true;
                }
                _context.RemoveRange(item);
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");

            }
            return NotFound();
        }
        

    }
}