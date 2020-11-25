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
    public class OpleidingenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OpleidingenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Opleidingen
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Opleidingen.Include(o => o.Algemeenheden).Include(o => o.Categorie).Include(o => o.Federatie).Include(o => o.Niveau).Include(o => o.Omschrijving).Include(o => o.Slot).Include(o => o.Voorwaarden);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Opleidingen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleidingen
                .Include(o => o.Algemeenheden)
                .Include(o => o.Categorie)
                .Include(o => o.Federatie)
                .Include(o => o.Niveau)
                .Include(o => o.Omschrijving)
                .Include(o => o.Slot)
                .Include(o => o.Voorwaarden)
                .FirstOrDefaultAsync(m => m.OpleidingID == id);
            if (opleiding == null)
            {
                return NotFound();
            }

            return View(opleiding);
        }

        // GET: Admin/Opleidingen/Create
        public IActionResult Create()
        {
            ViewData["AlgemeenhedenID"] = new SelectList(_context.Algemeenheden, "AlgemeenhedenID", "Beschrijving");
            ViewData["CategorieID"] = new SelectList(_context.Categorieen, "CategorieID", "Naam");
            ViewData["FederatieID"] = new SelectList(_context.Federaties, "FederatieID", "Naam");
            ViewData["NiveauID"] = new SelectList(_context.Niveaus, "NiveauID", "Naam");
            ViewData["OmschrijvingID"] = new SelectList(_context.Omschrijvingen, "OmschrijvingID", "Beschrijving");
            ViewData["SlotID"] = new SelectList(_context.Slot, "SlotID", "Beschrijving");
            ViewData["VoorwaardenID"] = new SelectList(_context.Voorwaarden, "VoorwaardenID", "Beschrijving");
            return View();
        }

        // POST: Admin/Opleidingen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OpleidingID,Naam,Prijs,NiveauID,FederatieID,CategorieID,SlotID,VoorwaardenID,OmschrijvingID,AlgemeenhedenID")] Opleiding opleiding)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opleiding);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlgemeenhedenID"] = new SelectList(_context.Algemeenheden, "AlgemeenhedenID", "Beschrijving", opleiding.AlgemeenhedenID);
            ViewData["CategorieID"] = new SelectList(_context.Categorieen, "CategorieID", "Naam", opleiding.CategorieID);
            ViewData["FederatieID"] = new SelectList(_context.Federaties, "FederatieID", "Naam", opleiding.FederatieID);
            ViewData["NiveauID"] = new SelectList(_context.Niveaus, "NiveauID", "Naam", opleiding.NiveauID);
            ViewData["OmschrijvingID"] = new SelectList(_context.Omschrijvingen, "OmschrijvingID", "Beschrijving", opleiding.OmschrijvingID);
            ViewData["SlotID"] = new SelectList(_context.Slot, "SlotID", "Beschrijving", opleiding.SlotID);
            ViewData["VoorwaardenID"] = new SelectList(_context.Voorwaarden, "VoorwaardenID", "Beschrijving", opleiding.VoorwaardenID);
            return View(opleiding);
        }

        // GET: Admin/Opleidingen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleidingen.FindAsync(id);
            if (opleiding == null)
            {
                return NotFound();
            }
            ViewData["AlgemeenhedenID"] = new SelectList(_context.Algemeenheden, "AlgemeenhedenID", "Beschrijving", opleiding.AlgemeenhedenID);
            ViewData["CategorieID"] = new SelectList(_context.Categorieen, "CategorieID", "Naam", opleiding.CategorieID);
            ViewData["FederatieID"] = new SelectList(_context.Federaties, "FederatieID", "Naam", opleiding.FederatieID);
            ViewData["NiveauID"] = new SelectList(_context.Niveaus, "NiveauID", "Naam", opleiding.NiveauID);
            ViewData["OmschrijvingID"] = new SelectList(_context.Omschrijvingen, "OmschrijvingID", "Beschrijving", opleiding.OmschrijvingID);
            ViewData["SlotID"] = new SelectList(_context.Slot, "SlotID", "Beschrijving", opleiding.SlotID);
            ViewData["VoorwaardenID"] = new SelectList(_context.Voorwaarden, "VoorwaardenID", "Beschrijving", opleiding.VoorwaardenID);
            return View(opleiding);
        }

        // POST: Admin/Opleidingen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OpleidingID,Naam,Prijs,NiveauID,FederatieID,CategorieID,SlotID,VoorwaardenID,OmschrijvingID,AlgemeenhedenID")] Opleiding opleiding)
        {
            if (id != opleiding.OpleidingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opleiding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpleidingExists(opleiding.OpleidingID))
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
            ViewData["AlgemeenhedenID"] = new SelectList(_context.Algemeenheden, "AlgemeenhedenID", "Beschrijving", opleiding.AlgemeenhedenID);
            ViewData["CategorieID"] = new SelectList(_context.Categorieen, "CategorieID", "Naam", opleiding.CategorieID);
            ViewData["FederatieID"] = new SelectList(_context.Federaties, "FederatieID", "Naam", opleiding.FederatieID);
            ViewData["NiveauID"] = new SelectList(_context.Niveaus, "NiveauID", "Naam", opleiding.NiveauID);
            ViewData["OmschrijvingID"] = new SelectList(_context.Omschrijvingen, "OmschrijvingID", "Beschrijving", opleiding.OmschrijvingID);
            ViewData["SlotID"] = new SelectList(_context.Slot, "SlotID", "Beschrijving", opleiding.SlotID);
            ViewData["VoorwaardenID"] = new SelectList(_context.Voorwaarden, "VoorwaardenID", "Beschrijving", opleiding.VoorwaardenID);
            return View(opleiding);
        }

        // GET: Admin/Opleidingen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleidingen
                .Include(o => o.Algemeenheden)
                .Include(o => o.Categorie)
                .Include(o => o.Federatie)
                .Include(o => o.Niveau)
                .Include(o => o.Omschrijving)
                .Include(o => o.Slot)
                .Include(o => o.Voorwaarden)
                .FirstOrDefaultAsync(m => m.OpleidingID == id);
            if (opleiding == null)
            {
                return NotFound();
            }

            return View(opleiding);
        }

        // POST: Admin/Opleidingen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opleiding = await _context.Opleidingen.FindAsync(id);
            _context.Opleidingen.Remove(opleiding);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpleidingExists(int id)
        {
            return _context.Opleidingen.Any(e => e.OpleidingID == id);
        }
    }
}
