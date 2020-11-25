using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectWebApp.Models
{
    public class Federatie
    {
        [Key]
        public int FederatieID { get; set; }
        [Required]
        public string Naam { get; set; }
        public ICollection<Opleiding> Opleidingen { get; set; }
    }
}
