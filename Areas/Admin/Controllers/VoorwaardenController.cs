using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models;

namespace ProjectWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VoorwaardenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoorwaardenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Voorwaarden
        public async Task<IActionResult> Index()
        {
            return View(await _context.Voorwaarden.ToListAsync());
        }

        // GET: Admin/Voorwaarden/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voorwaarden = await _context.Voorwaarden
                .FirstOrDefaultAsync(m => m.VoorwaardenID == id);
            if (voorwaarden == null)
            {
                return NotFound();
            }

            return View(voorwaarden);
        }

        // GET: Admin/Voorwaarden/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Voorwaarden/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VoorwaardenID,Titel,Beschrijving")] Voorwaarden voorwaarden)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voorwaarden);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voorwaarden);
        }

        // GET: Admin/Voorwaarden/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voorwaarden = await _context.Voorwaarden.FindAsync(id);
            if (voorwaarden == null)
            {
                return NotFound();
            }
            return View(voorwaarden);
        }

        // POST: Admin/Voorwaarden/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VoorwaardenID,Titel,Beschrijving")] Voorwaarden voorwaarden)
        {
            if (id != voorwaarden.VoorwaardenID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voorwaarden);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoorwaardenExists(voorwaarden.VoorwaardenID))
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
            return View(voorwaarden);
        }

        // GET: Admin/Voorwaarden/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voorwaarden = await _context.Voorwaarden
                .FirstOrDefaultAsync(m => m.VoorwaardenID == id);
            if (voorwaarden == null)
            {
                return NotFound();
            }

            return View(voorwaarden);
        }

        // POST: Admin/Voorwaarden/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voorwaarden = await _context.Voorwaarden.FindAsync(id);
            _context.Voorwaarden.Remove(voorwaarden);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoorwaardenExists(int id)
        {
            return _context.Voorwaarden.Any(e => e.VoorwaardenID == id);
        }
    }
}
