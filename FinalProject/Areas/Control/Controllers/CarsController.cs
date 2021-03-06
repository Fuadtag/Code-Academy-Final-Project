﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject.Areas.Control.Controllers
{
    [Authorize]
    [Area("Control")]
    public class CarsController : Controller
    {
        private readonly RentNowContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CarsController(RentNowContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHostEnvironment = webHost;
        }

        // GET: Control/Cars
        public async Task<IActionResult> Index()
        {
            var rentNowContext = _context.Cars.Include(c => c.Model).Include(c => c.Model.CarBrand).Where(c => c.Status == true);
            return View(await rentNowContext.ToListAsync());
        }

        // GET: Control/Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Model)
                .Include(c => c.Model.CarBrand)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Control/Cars/Create
        public IActionResult Create()
        {
            ViewData["CarModelId"] = new SelectList(_context.CarModels, "Id", "Name");
            return View();
        }

        // POST: Control/Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Car car)
        {
            if (ModelState.IsValid)
            {
                if (car.PhotoFile != null && car.DetailPhotoFile != null && car.CartPhotoFile != null)
                {
                    try
                    {
                        FileManager manager = new FileManager(_webHostEnvironment);
                        car.Photo = manager.Upload(car.PhotoFile);
                        car.CartPhoto = manager.Upload(car.CartPhotoFile);
                        car.DetailPhoto = manager.Upload(car.DetailPhotoFile);
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("PhotoUplaod", e.Message);
                        throw;
                    }
                }
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarModelId"] = new SelectList(_context.CarModels, "Id", "Name", car.CarModelId);
            return View(car);
        }

        // GET: Control/Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            ViewData["CarModelId"] = new SelectList(_context.CarModels, "Id", "Name", car.CarModelId);
            return View(car);
        }

        // POST: Control/Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CarModelId,Transmission,Fuel,Passsenger,Luggage,Door,Title,DailyPrice,Discount,Description,Status,Photo,CartPhoto,DetailPhoto")] Car car)
        {
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Id))
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
            ViewData["CarModelId"] = new SelectList(_context.CarModels, "Id", "Name", car.CarModelId);
            return View(car);
        }

        // GET: Control/Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Model)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            
            return View(car);
        }

        // POST: Control/Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var car = await _context.Cars.FindAsync(id);

            car.Status = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}
