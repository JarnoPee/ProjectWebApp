using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
    public class Algemeenheden
    {
        [Key]
        public int AlgemeenhedenID { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public string Beschrijving { get; set; }
        public ICollection<Opleiding> Opleidingen { get; set; }
    }
}
