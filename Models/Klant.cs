using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectWebApp.Models
{
    public class Klant
    {
        [Key]
        public int KlantID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Naam { get; set; }
        [Required]
        [MaxLength(100)]
        public string Voornaam { get; set; }
        [Required]
        public string Email { get; set; }
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
        [Required]
        [MinLength(8)]
        public string Paswoord { get; set; }
    }
}
