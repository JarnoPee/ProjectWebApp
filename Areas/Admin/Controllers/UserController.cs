using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models;
using ProjectWebApp.Utility;
using ProjectWebApp.ViewModel;

namespace ProjectWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StatischeDetails.Role_Admin)]

    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public UserController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var UserManagerViewModel = new List<UserManagerViewModel>();
            List<ProjectWebApp.Models.Klant> klantenLijst = await _context.Klanten.ToListAsync();
            foreach (var klant in klantenLijst)
            {
                var ViewModel = new UserManagerViewModel();
                ViewModel.Naam = klant.Naam;
                ViewModel.Voornaam = klant.Voornaam;
                ViewModel.Email = klant.Email;
                ViewModel.PhoneNumber = klant.PhoneNumber;
                ViewModel.Land = klant.Land;
                ViewModel.Rol = _userManager.GetRolesAsync(klant).Result.FirstOrDefault();
                UserManagerViewModel.Add(ViewModel);
            }
            return View(UserManagerViewModel);

        }
    }
}
