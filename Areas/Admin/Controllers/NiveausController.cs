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
    public class NiveausController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NiveausController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Niveaus
        public async Task<IActionResult> Index()
        {
            return View(await _context.Niveaus.ToListAsync());
        }

        // GET: Admin/Niveaus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niveau = await _context.Niveaus
                .FirstOrDefaultAsync(m => m.NiveauID == id);
            if (niveau == null)
            {
                return NotFound();
            }

            return View(niveau);
        }

        // GET: Admin/Niveaus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Niveaus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NiveauID,Naam")] Niveau niveau)
        {
            if (ModelState.IsValid)
            {
                _context.Add(niveau);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(niveau);
        }

        // GET: Admin/Niveaus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niveau = await _context.Niveaus.FindAsync(id);
            if (niveau == null)
            {
                return NotFound();
            }
            return View(niveau);
        }

        // POST: Admin/Niveaus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NiveauID,Naam")] Niveau niveau)
        {
            if (id != niveau.NiveauID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(niveau);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NiveauExists(niveau.NiveauID))
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
            return View(niveau);
        }

        // GET: Admin/Niveaus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niveau = await _context.Niveaus
                .FirstOrDefaultAsync(m => m.NiveauID == id);
            if (niveau == null)
            {
                return NotFound();
            }

            return View(niveau);
        }

        // POST: Admin/Niveaus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var niveau = await _context.Niveaus.FindAsync(id);
            _context.Niveaus.Remove(niveau);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NiveauExists(int id)
        {
            return _context.Niveaus.Any(e => e.NiveauID == id);
        }
    }
}
