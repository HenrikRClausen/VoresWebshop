using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoresWebshop.Models {
    public class OrdreLinie {
        public int OrdreLinieID { get; set; }
        public int OrdreID { get; set; }
        public int ProduktID { get; set; }
        public DateTime Oprettet { get; set; }
        public uint Antal { get; set; }
        public decimal StykPris { get; set; }
    }
}
