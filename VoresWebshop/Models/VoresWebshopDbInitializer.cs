using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VoresWebshop.Models {
    public class VoresWebshopDbInitializer : DropCreateDatabaseAlways<VoresWebshopDb> {
        protected override void Seed(VoresWebshopDb context) {
            base.Seed(context);

            var brugere = new List<Bruger>
            {
                new Bruger{
                    BrugerRolle = 1,
                    Fornavn = "Stefan",
                    Efternavn = "Hartung",
                    Adresse = "Hjemvej 4",
                    Postnummer = 8240,
                    By = "Hjemby",
                    Telefon = "12345678",
                    ePost = "mig@min_server.dk",
                    Oprettet = DateTime.Today
                }
            };

            brugere.ForEach(b => context.Brugere.Add(b));
            context.SaveChanges();

            var produkter = new List<Produkt>
            {
                new Produkt
                {
                    Navn = "Sko",
                    Pris = 199.95m,
                    KortBeskrivelse = "Pæn sko",
                    Beskrivelse = "Det er virkelig en pæn sko, alle burde købe denne sko!",
                    Antal = 104,
                    Oprettet = DateTime.Parse("2018-12-24")
                }
            };
            produkter.ForEach(p => context.Produkter.Add(p));
            context.SaveChanges();

            var ordrer = new List<Ordre>
            {
                new Ordre
                {
                    BrugerID = 1,
                    Oprettet = DateTime.Parse("2019-01-01"),
                    Godkendt = DateTime.Today,
                    OrdreLinier = new List<OrdreLinie>
                    {
                        new OrdreLinie
                        {
                            ProduktID = 1,
                            Oprettet = DateTime.Today,
                            Antal = 4,
                            StykPris = produkter[0].Pris * 0.80m
                        }
                    }
                }
            };

            ordrer.ForEach(o => context.Ordrer.Add(o));
            context.SaveChanges();


        }
    }
}