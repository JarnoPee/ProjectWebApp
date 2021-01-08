using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Areas.Identity.Data
{
    public class CustomUser
    {
        [PersonalData]
    public Models.Klant Klant { get; set; }
    }
}
