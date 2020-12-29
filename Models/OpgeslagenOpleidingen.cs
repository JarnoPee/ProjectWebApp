using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApp.Models
{
    public class OpgeslagenOpleidingen
    {
        public OpgeslagenOpleidingen()
        {
            Count = 1;
        }
        [Key]
        public int OpgeslagenOpleidingenID { get; set; }

        public string KlantId { get; set; }
        [ForeignKey("KlantId")]
        public Klant Klant { get; set; }

        public int OpleidingId { get; set; }
        [ForeignKey("OpleidingId")]
        public Opleiding Opleiding { get; set; }

        [Range(1, 1000, ErrorMessage = "Gelieve en waarde tussen 1 en 1000 te geven")]
        public int Count { get; set; }

        [NotMapped]
        public double Price { get; set; }
    }
}