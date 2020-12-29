using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectWebApp.Data.UnitOfWork;
using ProjectWebApp.Models;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ProjectWebApp.Areas.Klant.Controllers
{
    [Area("Klant")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Opleidingen.Include(o => o.Algemeenheden).Include(o => o.Categorie).Include(o => o.Federatie).Include(o => o.Niveau).Include(o => o.Omschrijving).Include(o => o.Slot).Include(o => o.Voorwaarden);
            return View(await applicationDbContext.ToListAsync());
        }


        public IActionResult Details(int id)
        {
            var opleidingFromDb = _unitOfWork.OpleidingRepository.GetFirstOrDefault(u => u.Id == id, includeProperties: "Algemeenheden,Categorie,Federatie,Niveau,Omschrijving,Slot,Voorwaarden");
            OpgeslagenOpleidingen opgeslagenOpleidingObj = new OpgeslagenOpleidingen()
            {
                Opleiding = opleidingFromDb,
                OpleidingId = opleidingFromDb.Id
            };
            return View(opgeslagenOpleidingObj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Details(OpgeslagenOpleidingen OpgeslagenOpleidingObject)
        {
            OpgeslagenOpleidingObject.OpleidingId = 0;
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                OpgeslagenOpleidingObject.KlantId = claim.Value;

                OpgeslagenOpleidingen opgeslagenOpleidingObjectFromDB = _unitOfWork.OpgeslagenOpleidingenRepository.GetFirstOrDefault( u => u.Klant == OpgeslagenOpleidingObject.Klant && u.OpleidingId == OpgeslagenOpleidingObject.OpleidingId, includeProperties: "Opleiding");

                if (opgeslagenOpleidingObjectFromDB == null)
                {
                    //no records exists in database for that product for that user
                    _unitOfWork.OpgeslagenOpleidingenRepository.Create(OpgeslagenOpleidingObject);
                }
                else
                {
                    opgeslagenOpleidingObjectFromDB.Count += OpgeslagenOpleidingObject.Count;
                }
                await _unitOfWork.Save();

                //var count = _unitOfWork.OpgeslagenOpleidingenRepository
                //    .GetAll(c => c.ApplicationUserId == CartObject.ApplicationUserId)
                //    .ToList().Count();

                ////HttpContext.Session.SetObject(SD.ssShoppingCart, CartObject);
                //HttpContext.Session.SetInt32(SD.ssShoppingCart, count);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                var opleidingFromDb = _unitOfWork.OpleidingRepository.GetFirstOrDefault(u => u.Id == OpgeslagenOpleidingObject.OpleidingId, includeProperties: "Algemeenheden,Categorie,Federatie,Niveau,Omschrijving,Slot,Voorwaarden");
                OpgeslagenOpleidingen opgeslagenOpleidingObj = new OpgeslagenOpleidingen()
                {
                    Opleiding = opleidingFromDb,
                    OpleidingId = opleidingFromDb.Id
                };
                return View(opgeslagenOpleidingObj);
            }


        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
