using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoresWebshop.Models {
    public class Produkt {
        public int ProduktID { get; set; }

        [Required]
        public string Navn { get; set; }
        public decimal Pris { get; set; }

        [Required]
        public string KortBeskrivelse { get; set; }

        [Required]
        public string Beskrivelse { get; set; }

        [Required]
        public uint Antal { get; set; }
        public byte[] Billede { get; set; }
        public DateTime Oprettet { get; set; }
    }
}
