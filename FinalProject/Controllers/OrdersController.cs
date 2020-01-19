using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class OrdersController : Controller
    {
        private readonly RentNowContext _context;
        public OrdersController(RentNowContext context)
        {
            _context = context;
        }
        public IActionResult Create(Order order, int carid)
        {
            var token = Request.Cookies["Token"];

            Customer customer = _context.Customers.FirstOrDefault(c => c.Token == token);
            if (customer != null)
            {
                

                Order neworder = new Order
                {
                    
                    CustomerId = customer.Id,
                    Total = 0,
                    PickupLocation = order.PickupLocation,
                    PickupDate = order.PickupDate,
                    DropLocation = order.DropLocation,
                    DropDate = order.DropDate
                     
                };
                _context.Orders.Add(neworder);
                _context.SaveChanges();
                OrderItem orderItem = new OrderItem
                {
                    CarId = carid,
                    OrderId = neworder.Id,
                    

                };
                Car car = _context.Cars.FirstOrDefault(c => c.Id == carid);
                car.Status = false;
                _context.OrderItems.Add(orderItem);
                _context.SaveChanges();
            }
            return RedirectToAction("Checkout", "Pages", new {id = customer.Id });
        }

        public IActionResult Delete(int id)
        {
            Order order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                var item = _context.OrderItems.Where(o => o.OrderId == order.Id);
                _context.RemoveRange(item);
                _context.Orders.Remove(order);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            return NotFound();
        }
        

    }
}