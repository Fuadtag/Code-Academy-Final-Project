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
    public class OurVisionsController : Controller
    {
        private readonly RentNowContext _context;

        public OurVisionsController(RentNowContext context)
        {
            _context = context;
        }

        // GET: Control/OurVisions
        public async Task<IActionResult> Index()
        {
            return View(await _context.OurVisions.ToListAsync());
        }

        // GET: Control/OurVisions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourVision = await _context.OurVisions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourVision == null)
            {
                return NotFound();
            }

            return View(ourVision);
        }

        // GET: Control/OurVisions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/OurVisions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Text")] OurVision ourVision)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ourVision);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ourVision);
        }

        // GET: Control/OurVisions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourVision = await _context.OurVisions.FindAsync(id);
            if (ourVision == null)
            {
                return NotFound();
            }
            return View(ourVision);
        }

        // POST: Control/OurVisions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Text")] OurVision ourVision)
        {
            if (id != ourVision.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ourVision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OurVisionExists(ourVision.Id))
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
            return View(ourVision);
        }

        // GET: Control/OurVisions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourVision = await _context.OurVisions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourVision == null)
            {
                return NotFound();
            }

            return View(ourVision);
        }

        // POST: Control/OurVisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ourVision = await _context.OurVisions.FindAsync(id);
            _context.OurVisions.Remove(ourVision);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OurVisionExists(int id)
        {
            return _context.OurVisions.Any(e => e.Id == id);
        }
    }
}
