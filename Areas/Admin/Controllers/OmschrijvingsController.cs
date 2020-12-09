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

    public class OmschrijvingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OmschrijvingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Omschrijvings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Omschrijvingen.ToListAsync());
        }

        // GET: Admin/Omschrijvings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var omschrijving = await _context.Omschrijvingen
                .FirstOrDefaultAsync(m => m.OmschrijvingID == id);
            if (omschrijving == null)
            {
                return NotFound();
            }

            return View(omschrijving);
        }

        // GET: Admin/Omschrijvings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Omschrijvings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OmschrijvingID,Titel,Beschrijving")] Omschrijving omschrijving)
        {
            if (ModelState.IsValid)
            {
                _context.Add(omschrijving);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(omschrijving);
        }

        // GET: Admin/Omschrijvings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var omschrijving = await _context.Omschrijvingen.FindAsync(id);
            if (omschrijving == null)
            {
                return NotFound();
            }
            return View(omschrijving);
        }

        // POST: Admin/Omschrijvings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OmschrijvingID,Titel,Beschrijving")] Omschrijving omschrijving)
        {
            if (id != omschrijving.OmschrijvingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(omschrijving);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OmschrijvingExists(omschrijving.OmschrijvingID))
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
            return View(omschrijving);
        }

        // GET: Admin/Omschrijvings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var omschrijving = await _context.Omschrijvingen
                .FirstOrDefaultAsync(m => m.OmschrijvingID == id);
            if (omschrijving == null)
            {
                return NotFound();
            }

            return View(omschrijving);
        }

        // POST: Admin/Omschrijvings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var omschrijving = await _context.Omschrijvingen.FindAsync(id);
            _context.Omschrijvingen.Remove(omschrijving);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OmschrijvingExists(int id)
        {
            return _context.Omschrijvingen.Any(e => e.OmschrijvingID == id);
        }
    }
}
