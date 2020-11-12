using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectWebApp.Models
{
    public class Omschrijving
    {
        [Key]
        public int OmschrijvingID { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public string Beschrijving { get; set; }
        public int OpleidingId { get; set; }
        public Opleiding Opleiding { get; set; }
    }
}
