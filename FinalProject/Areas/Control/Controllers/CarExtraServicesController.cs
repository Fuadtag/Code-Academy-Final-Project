using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject.Areas.Control.Controllers
{
    [Authorize]
    [Area("Control")]
    public class CarExtraServicesController : Controller
    {
        private readonly RentNowContext _context;

        public CarExtraServicesController(RentNowContext context)
        {
            _context = context;
        }

        // GET: Control/CarExtraServices
        public async Task<IActionResult> Index()
        {
            var rentNowContext = _context.CarExtraServices.Include(c => c.OrderItem);
            return View(await rentNowContext.ToListAsync());
        }

        // GET: Control/CarExtraServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carExtraService = await _context.CarExtraServices
                .Include(c => c.OrderItem)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carExtraService == null)
            {
                return NotFound();
            }

            return View(carExtraService);
        }

        // GET: Control/CarExtraServices/Create
        public IActionResult Create()
        {
            ViewData["OrderItemId"] = new SelectList(_context.OrderItems, "Id", "Id");
            return View();
        }

        // POST: Control/CarExtraServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,OrderItemId")] CarExtraService carExtraService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carExtraService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderItemId"] = new SelectList(_context.OrderItems, "Id", "Id", carExtraService.OrderItemId);
            return View(carExtraService);
        }

        // GET: Control/CarExtraServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carExtraService = await _context.CarExtraServices.FindAsync(id);
            if (carExtraService == null)
            {
                return NotFound();
            }
            ViewData["OrderItemId"] = new SelectList(_context.OrderItems, "Id", "Id", carExtraService.OrderItemId);
            return View(carExtraService);
        }

        // POST: Control/CarExtraServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,OrderItemId")] CarExtraService carExtraService)
        {
            if (id != carExtraService.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carExtraService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExtraServiceExists(carExtraService.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderItemId"] = new SelectList(_context.OrderItems, "Id", "Id", carExtraService.OrderItemId);
            return View(carExtraService);
        }

        // GET: Control/CarExtraServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carExtraService = await _context.CarExtraServices
                .Include(c => c.OrderItem)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carExtraService == null)
            {
                return NotFound();
            }

            return View(carExtraService);
        }

        // POST: Control/CarExtraServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carExtraService = await _context.CarExtraServices.FindAsync(id);
            _context.CarExtraServices.Remove(carExtraService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExtraServiceExists(int id)
        {
            return _context.CarExtraServices.Any(e => e.Id == id);
        }
    }
}
