using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using ProjectWebApp.Data.UnitOfWork;
using ProjectWebApp.Utility;


namespace ProjectWebApp.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUnitOfWork _unitOFWork;
        private readonly IWebHostEnvironment _hostEnvironment;


        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager, 
            IUnitOfWork unitOfWork,
            IWebHostEnvironment hostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _hostEnvironment = hostEnvironment;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _unitOFWork = unitOfWork;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Wachtwoord")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Bevestig Wachtwoord")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [MaxLength(100)]
            public string Naam { get; set; }
            [Required]
            [MaxLength(100)]
            public string Voornaam { get; set; }
            [Required]
            [MaxLength(100)]
            public string Land { get; set; }
            [Required]
            [MaxLength(255)]
            public string Straat { get; set; }
            [Required]
            [MaxLength(10)]
            public string Huisnummer { get; set; }
            [Required]
            [MaxLength(20)]
            public string Postcode { get; set; }
            [Required]
            [MaxLength(100)]
            public string Gemeente { get; set; }
            [Display(Name = "GSM nummer")]
            public string PhoneNumber { get; set; }
            public string Rol { get; set; }
            public IEnumerable<SelectListItem> RoleList { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            Input = new InputModel()
            {
                RoleList = _roleManager.Roles.Select(x => x.Name).Select(i => new SelectListItem //.Where(u => u.Name != StatischeDetails.Role_User_Indi) als de admin gebruiker allen maar admin gebruikers wil aanmaken
                {
                    Text = i,
                    Value = i
                })
            };
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ProjectWebApp.Models.Klant
                { 
                    UserName = Input.Email, 
                    Email = Input.Email,
                    Naam = Input.Naam,
                    Voornaam = Input.Voornaam,
                    PhoneNumber = Input.PhoneNumber,
                    Land = Input.Land,
                    Straat = Input.Straat,
                    Huisnummer = Input.Huisnummer,
                    Postcode = Input.Postcode,
                    Gemeente = Input.Gemeente,
                    Rol = Input.Rol
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Nieuwe gebruiker gemaakt met wachtwoord.");

                    if (user.Rol == null)
                    {
                        await _userManager.AddToRoleAsync(user, StatischeDetails.Role_User_Indi);
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, user.Rol);
                    }
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);


                    var PathToFile = _hostEnvironment.WebRootPath + Path.DirectorySeparatorChar.ToString()
                        + "Templates" + Path.DirectorySeparatorChar.ToString() + "EmailTemplates"
                        + Path.DirectorySeparatorChar.ToString() + "Confirm_Account_Registration.html";

                    var subject = "Confirm Account Registration";
                    string HtmlBody = "";
                    using (StreamReader streamReader = System.IO.File.OpenText(PathToFile))
                    {
                        HtmlBody = streamReader.ReadToEnd();
                    }

                    //{0} : Subject  
                    //{1} : DateTime  
                    //{2} : Name  
                    //{3} : Email  
                    //{4} : Message  
                    //{5} : callbackURL  

                    string Message = $"Gelieve uw account te bevestigen door <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>HIER</a> te klikken.";

                    string messageBody = string.Format(HtmlBody,
                        subject,
                        String.Format("{0:dddd, d MMMM yyyy}", DateTime.Now),
                        user.Naam,
                        user.Email,
                        Message,
                        callbackUrl
                        );
                    await _emailSender.SendEmailAsync(Input.Email, "Bevestig uw email", messageBody);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        if (user.Rol ==null)
                        {
                            await _signInManager.SignInAsync(user, isPersistent: false);
                            return LocalRedirect(returnUrl);
                        }
                        else
                        {
                            //admin gaat nieuwe gebruiker aanmaken
                            return RedirectToAction("Index", "User", new { Area = "Admin" });
                        }
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            Input = new InputModel()
            {
                RoleList = _roleManager.Roles.Select(x => x.Name).Select(i => new SelectListItem //.Where(u => u.Name != StatischeDetails.Role_User_Indi) als de admin gebruiker allen maar admin gebruikers wil aanmaken
                {
                    Text = i,
                    Value = i
                })
            };

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
