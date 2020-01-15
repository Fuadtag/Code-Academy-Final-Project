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
    public class WhatWeOffersController : Controller
    {
        private readonly RentNowContext _context;

        public WhatWeOffersController(RentNowContext context)
        {
            _context = context;
        }

        // GET: Control/WhatWeOffers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Offers.ToListAsync());
        }

        // GET: Control/WhatWeOffers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var whatWeOffer = await _context.Offers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (whatWeOffer == null)
            {
                return NotFound();
            }

            return View(whatWeOffer);
        }

        // GET: Control/WhatWeOffers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/WhatWeOffers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Icon,Title,Text")] WhatWeOffer whatWeOffer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(whatWeOffer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(whatWeOffer);
        }

        // GET: Control/WhatWeOffers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var whatWeOffer = await _context.Offers.FindAsync(id);
            if (whatWeOffer == null)
            {
                return NotFound();
            }
            return View(whatWeOffer);
        }

        // POST: Control/WhatWeOffers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Icon,Title,Text")] WhatWeOffer whatWeOffer)
        {
            if (id != whatWeOffer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(whatWeOffer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WhatWeOfferExists(whatWeOffer.Id))
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
            return View(whatWeOffer);
        }

        // GET: Control/WhatWeOffers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var whatWeOffer = await _context.Offers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (whatWeOffer == null)
            {
                return NotFound();
            }

            return View(whatWeOffer);
        }

        // POST: Control/WhatWeOffers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var whatWeOffer = await _context.Offers.FindAsync(id);
            _context.Offers.Remove(whatWeOffer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WhatWeOfferExists(int id)
        {
            return _context.Offers.Any(e => e.Id == id);
        }
    }
}
