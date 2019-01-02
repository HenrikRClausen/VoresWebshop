using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace VoresWebshop.Models {
    public class VoresWebshopDb : System.Data.Entity.DbContext {
        public DbSet<Bruger> Brugere { get; set; }
        public DbSet<Ordre> Ordrer { get; set; }
        public DbSet<OrdreLinie> OrdreLinier { get; set; }
        public DbSet<Produkt> Produkter { get; set; }
    }
}