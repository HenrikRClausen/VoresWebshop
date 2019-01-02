using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoresWebshop.Models {
    public class Bruger {
        public int BrugerID { get; set; }
        public int BrugerRolle{ get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Adresse { get; set; }
        public int Postnummer { get; set; }
        public string By { get; set; }
        public string Telefon { get; set; }
        public string ePost { get; set; }
        public DateTime Oprettet { get; set; }
        }
    }
