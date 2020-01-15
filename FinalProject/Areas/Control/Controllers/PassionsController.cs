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
    public class PassionsController : Controller
    {
        private readonly RentNowContext _context;

        public PassionsController(RentNowContext context)
        {
            _context = context;
        }

        // GET: Control/Passions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Passions.ToListAsync());
        }

        // GET: Control/Passions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passion = await _context.Passions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passion == null)
            {
                return NotFound();
            }

            return View(passion);
        }

        // GET: Control/Passions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/Passions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Photo,SubTitle,Title,Text")] Passion passion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passion);
        }

        // GET: Control/Passions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passion = await _context.Passions.FindAsync(id);
            if (passion == null)
            {
                return NotFound();
            }
            return View(passion);
        }

        // POST: Control/Passions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Photo,SubTitle,Title,Text")] Passion passion)
        {
            if (id != passion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassionExists(passion.Id))
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
            return View(passion);
        }

        // GET: Control/Passions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passion = await _context.Passions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passion == null)
            {
                return NotFound();
            }

            return View(passion);
        }

        // POST: Control/Passions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var passion = await _context.Passions.FindAsync(id);
            _context.Passions.Remove(passion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassionExists(int id)
        {
            return _context.Passions.Any(e => e.Id == id);
        }
    }
}
