using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoresWebshop.Models
{
    public class Ordre
    {
        public int OrdreID { get; set; }
        public int BrugerID { get; set; }
        public DateTime Oprettet { get; set; }
        public DateTime Godkendt { get; set; }
        public DateTime Afsendt { get; set; }
        public DateTime Afsluttet { get; set; }
        public List<OrdreLinie> OrdreLinie { get; set; }
    }
}
