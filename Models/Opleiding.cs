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
        public double Prijs { get; set; }
        public int NiveauID { get; set; }
        public int FederatieID { get; set; }
        public int CategorieID { get; set; }
        public int SlotID { get; set; }
        public int VoorwaardenID { get; set; }
        public int OmschrijvingID { get; set; }
        public int AlgemeenhedenID { get; set; }
        public Niveau Niveau { get; set; }
        public Federatie Federatie { get; set; }
        public Categorie Categorie { get; set; }
        public Slot Slot { get; set; }
        public Voorwaarden Voorwaarden { get; set; }
        public Omschrijving Omschrijving { get; set; }
        public Algemeenheden Algemeenheden { get; set; }
    }
}
