using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using FinalProject.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject.Areas.Control.Controllers
{
    [Authorize]
    [Area("Control")]
    public class GalleryItemsController : Controller
    {
        private readonly RentNowContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GalleryItemsController(RentNowContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Control/GalleryItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.GalleryItems.ToListAsync());
        }

        // GET: Control/GalleryItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galleryItem = await _context.GalleryItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galleryItem == null)
            {
                return NotFound();
            }

            return View(galleryItem);
        }

        // GET: Control/GalleryItems/Create
        public IActionResult Create()
        {
            ViewData["GalleryId"] = new SelectList(_context.Galleries, "Id", "Id");
            return View();
        }

        // POST: Control/GalleryItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GalleryId,Photo,PhotoSm")] GalleryItem galleryItem)
        {
            if (galleryItem.PhotoFile != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    galleryItem.Photo = fileManager.Upload(galleryItem.PhotoFile);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoFile", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(galleryItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(galleryItem);
        }

        // GET: Control/GalleryItems/Edit/5
        public async Task<IActionResult> Edit(int? id)

        {

            if (id == null)
            {
                return NotFound();
            }

            var galleryItem = await _context.GalleryItems.FindAsync(id);

            if (galleryItem == null)
            {
                return NotFound();
            }
            return View(galleryItem);
        }

        // POST: Control/GalleryItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GalleryId,Photo,PhotoSm")] GalleryItem galleryItem)
        {
            if (id != galleryItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(galleryItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GalleryItemExists(galleryItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (galleryItem.PhotoSmFile != null)
                {
                    try
                    {
                        FileManager fileManager = new FileManager(_webHostEnvironment);
                        galleryItem.PhotoSm = fileManager.Upload(galleryItem.PhotoSmFile);
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("PhotoSmFile", e.Message);
                    }
                }
                return RedirectToAction(nameof(Index), "Galleries");
            }
            return View(galleryItem);
        }

        // GET: Control/GalleryItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galleryItem = await _context.GalleryItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galleryItem == null)
            {
                return NotFound();
            }

            return View(galleryItem);
        }

        // POST: Control/GalleryItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var galleryItem = await _context.GalleryItems.FindAsync(id);
            _context.GalleryItems.Remove(galleryItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "Galleries");
        }

        private bool GalleryItemExists(int id)
        {
            return _context.GalleryItems.Any(e => e.Id == id);
        }
    }
}
