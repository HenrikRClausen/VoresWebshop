using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoresWebshop.Models {
    public class Produkt {
        public int ProduktID { get; set; }
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public string KortBeskrivelse { get; set; }
        public string Beskrivelse { get; set; }
        public uint Antal { get; set; }
        public byte[] Billede { get; set; }
        public DateTime Oprettet { get; set; }
    }
}
