using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoresWebshop.Models {
    public class OrdreLinie {
        public int OrdreLinieID { get; set; }

        [Required]
        public int OrdreID { get; set; }

        [Required]
        public int ProduktID { get; set; }
        public DateTime Oprettet { get; set; }

        [Required]
        public uint Antal { get; set; }

        [Required]
        public decimal StykPris { get; set; }
    }


    
}
