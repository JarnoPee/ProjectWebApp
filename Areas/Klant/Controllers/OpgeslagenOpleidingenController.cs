using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models;
using ProjectWebApp.ViewModel;

namespace ProjectWebApp.Areas.Klant.Controllers
{
    [Area("Klant")]
    public class OpgeslagenOpleidingenController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        [BindProperty]
        public OpgeslagenOpleidingenViewModel OpgeslagenOpleidingenViewModel { get; set; }
        public OpgeslagenOpleidingenController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Klant/OpgeslagenOpleidingen
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OpgeslagenOpleidingen.Include(o => o.Klant).Include(o => o.Opleiding).Include(o => o.Opleiding.Algemeenheden).Where(x => x.KlantId == _userManager.GetUserId(User));
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Klant/OpgeslagenOpleidingen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opgeslagenOpleidingen = await _context.OpgeslagenOpleidingen
                .Include(o => o.Klant)
                .Include(o => o.Opleiding)
                .FirstOrDefaultAsync(m => m.OpgeslagenOpleidingenID == id);
            if (opgeslagenOpleidingen == null)
            {
                return NotFound();
            }

            return View(opgeslagenOpleidingen);
        }

        // POST: Klant/OpgeslagenOpleidingen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opgeslagenOpleidingen = await _context.OpgeslagenOpleidingen.FindAsync(id);
            _context.OpgeslagenOpleidingen.Remove(opgeslagenOpleidingen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpgeslagenOpleidingenExists(int id)
        {
            return _context.OpgeslagenOpleidingen.Any(e => e.OpgeslagenOpleidingenID == id);
        }
    }
}
