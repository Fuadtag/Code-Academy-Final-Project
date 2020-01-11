using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Areas.Control.Controllers
{
    [Area("Control")]
    public class AdvantagesController : Controller
    {
        private readonly RentNowContext _context;

        public AdvantagesController(RentNowContext context)
        {
            _context = context;
        }

        // GET: Control/Advantages
        public async Task<IActionResult> Index()
        {
            return View(await _context.Advantage.ToListAsync());
        }

        // GET: Control/Advantages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advantage = await _context.Advantage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advantage == null)
            {
                return NotFound();
            }

            return View(advantage);
        }

        // GET: Control/Advantages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/Advantages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Text")] Advantage advantage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advantage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advantage);
        }

        // GET: Control/Advantages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advantage = await _context.Advantage.FindAsync(id);
            if (advantage == null)
            {
                return NotFound();
            }
            return View(advantage);
        }

        // POST: Control/Advantages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Text")] Advantage advantage)
        {
            if (id != advantage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advantage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvantageExists(advantage.Id))
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
            return View(advantage);
        }

        // GET: Control/Advantages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advantage = await _context.Advantage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advantage == null)
            {
                return NotFound();
            }

            return View(advantage);
        }

        // POST: Control/Advantages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advantage = await _context.Advantage.FindAsync(id);
            _context.Advantage.Remove(advantage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvantageExists(int id)
        {
            return _context.Advantage.Any(e => e.Id == id);
        }
    }
}
