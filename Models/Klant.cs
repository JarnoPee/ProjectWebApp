using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectWebApp.Models
{
    public class Klant : IdentityUser
    {
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

        [NotMapped]
        public string Rol { get; set; }

        public List<OpgeslagenOpleidingen> OpgeslagenOpleidingens { get; set; }
    }
}
