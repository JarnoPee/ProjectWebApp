﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectWebApp.Models
{
    public class Voorwaarden
    {
        [Key]
        public int VoorwaardenID { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public string Beschrijving { get; set; }
        public ICollection<Opleiding> Opleidingen { get; set; }
    }
}
