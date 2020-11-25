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
    public class FederatiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FederatiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Federaties
        public async Task<IActionResult> Index()
        {
            return View(await _context.Federaties.ToListAsync());
        }

        // GET: Admin/Federaties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var federatie = await _context.Federaties
                .FirstOrDefaultAsync(m => m.FederatieID == id);
            if (federatie == null)
            {
                return NotFound();
            }

            return View(federatie);
        }

        // GET: Admin/Federaties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Federaties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FederatieID,Naam")] Federatie federatie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(federatie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(federatie);
        }

        // GET: Admin/Federaties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var federatie = await _context.Federaties.FindAsync(id);
            if (federatie == null)
            {
                return NotFound();
            }
            return View(federatie);
        }

        // POST: Admin/Federaties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FederatieID,Naam")] Federatie federatie)
        {
            if (id != federatie.FederatieID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(federatie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FederatieExists(federatie.FederatieID))
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
            return View(federatie);
        }

        // GET: Admin/Federaties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var federatie = await _context.Federaties
                .FirstOrDefaultAsync(m => m.FederatieID == id);
            if (federatie == null)
            {
                return NotFound();
            }

            return View(federatie);
        }

        // POST: Admin/Federaties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var federatie = await _context.Federaties.FindAsync(id);
            _context.Federaties.Remove(federatie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FederatieExists(int id)
        {
            return _context.Federaties.Any(e => e.FederatieID == id);
        }
    }
}
