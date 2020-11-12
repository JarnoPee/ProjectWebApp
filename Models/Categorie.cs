using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectWebApp.Models
{
    public class Categorie
    {
        [Key]
        public int CategorieID { get; set; } // Relatie met zijn eigen nog toevoegen!!!!
        [Display(Name = "Naam categorie")]
        [Required]
        [MaxLength(50)]
        public string Naam { get; set; }
        public int OpleidingId { get; set; }
        public Opleiding Opleiding { get; set; }
    }
}
