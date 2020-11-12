using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectWebApp.Models
{
    public class Opleiding
    {
        [Key]
        public int OpleidingID { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public double Prijs { get; set; }
        public ICollection<Niveau> Niveaus { get; set; }
        public ICollection<Federatie> Federaties { get; set; }
        public ICollection<Categorie> Categories { get; set; }
        public ICollection<Slot> Slots { get; set; }
        public ICollection<Voorwaarden> Voorwaardens { get; set; }
        public ICollection<Omschrijving> Omschrijvingen { get; set; }
        public ICollection<Algemeenheden> Algemeenheden { get; set; }
    }
}
