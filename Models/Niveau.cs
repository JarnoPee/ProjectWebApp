using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectWebApp.Models
{
    public class Niveau
    {
        [Key]
        public int NiveauID { get; set; }
        [Required]
        public string Naam { get; set; }
        public ICollection<Opleiding> Opleidingen { get; set; }
    }
}
