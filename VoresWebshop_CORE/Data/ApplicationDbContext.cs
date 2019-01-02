using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VoresWebshop.Models;

namespace VoresWebshop.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
    }

    public class VoresWebshopDb : Microsoft.EntityFrameworkCore.DbContext {
        public DbSet<Bruger> Brugere { get; set; }
        public DbSet<Ordre> Ordrer { get; set; }
        public DbSet<OrdreLinie> OrdreProdukter { get; set; }
        public DbSet<Produkt> Produkter { get; set; }
    }

    public static class VoresWebshopDbInitializer {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new VoresWebshopDb()) {

                }
        }
    }

}
