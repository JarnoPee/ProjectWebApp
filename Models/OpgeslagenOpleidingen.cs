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

        public string Klant { get; set; }
        [ForeignKey("Klant")]
        public Klant klant { get; set; }

        public int Opleiding { get; set; }
        [ForeignKey("Opleiding")]
        public Opleiding opleiding { get; set; }

        [Range(1, 1000, ErrorMessage = "Gelieve en waarde tussen 1 en 1000 te geven")]
        public int Count { get; set; }

        [NotMapped]
        public double Price { get; set; }
    }
}