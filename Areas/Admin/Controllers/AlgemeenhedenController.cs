using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models;
using ProjectWebApp.Utility;

namespace ProjectWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StatischeDetails.Role_Admin)]
    public class AlgemeenhedenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlgemeenhedenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Algemeenheden
        public async Task<IActionResult> Index()
        {
            return View(await _context.Algemeenheden.ToListAsync());
        }

        // GET: Admin/Algemeenheden/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var algemeenheden = await _context.Algemeenheden
                .FirstOrDefaultAsync(m => m.AlgemeenhedenID == id);
            if (algemeenheden == null)
            {
                return NotFound();
            }

            return View(algemeenheden);
        }

        // GET: Admin/Algemeenheden/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Algemeenheden/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlgemeenhedenID,Titel,Beschrijving")] Algemeenheden algemeenheden)
        {
            if (ModelState.IsValid)
            {
                _context.Add(algemeenheden);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(algemeenheden);
        }

        // GET: Admin/Algemeenheden/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var algemeenheden = await _context.Algemeenheden.FindAsync(id);
            if (algemeenheden == null)
            {
                return NotFound();
            }
            return View(algemeenheden);
        }

        // POST: Admin/Algemeenheden/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlgemeenhedenID,Titel,Beschrijving")] Algemeenheden algemeenheden)
        {
            if (id != algemeenheden.AlgemeenhedenID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(algemeenheden);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlgemeenhedenExists(algemeenheden.AlgemeenhedenID))
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
            return View(algemeenheden);
        }

        // GET: Admin/Algemeenheden/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var algemeenheden = await _context.Algemeenheden
                .FirstOrDefaultAsync(m => m.AlgemeenhedenID == id);
            if (algemeenheden == null)
            {
                return NotFound();
            }

            return View(algemeenheden);
        }

        // POST: Admin/Algemeenheden/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var algemeenheden = await _context.Algemeenheden.FindAsync(id);
            _context.Algemeenheden.Remove(algemeenheden);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlgemeenhedenExists(int id)
        {
            return _context.Algemeenheden.Any(e => e.AlgemeenhedenID == id);
        }
    }
}
