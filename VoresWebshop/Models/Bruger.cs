using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoresWebshop.Models {

    public class Bruger {
        public int BrugerID { get; set; }

        [Required]
        public int BrugerRolle{ get; set; }

        [Required]
        public string Fornavn { get; set; }

        [Required]
        public string Efternavn { get; set; }

        [Required]
        public string Adresse { get; set; }

        [Required]
        [MaxLength(4), MinLength(4)]
        [CheckValidPostnummer]
        public int Postnummer { get; set; }

        [Required]
        public string By { get; set; }

        [MinLength(8)]
        [CheckValidTelefon]
        public string Telefon { get; set; }

        [Required]
        [CheckValidEpost]
        public string ePost { get; set; }
        public DateTime Oprettet { get; set; }
    }

    

    public class CheckValidEpost : ValidationAttribute
    {
        public CheckValidEpost()
        {
            ErrorMessage = "ePost skal bestå af...";
        }

        public override bool IsValid(object value)
        {
            string epost = (string)value;
            //if (check epost mod regEx)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            return true;
        }
    }

    public class CheckValidPostnummer : ValidationAttribute
    {
        public CheckValidPostnummer()
        {
            ErrorMessage = "Postnummeret skal...";
        }

        public override bool IsValid(object value)
        {
            int postnummer = (int)value;
            if (postnummer.length > 4)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }

    public class CheckValidTelefon : ValidationAttribute
    {
        public CheckValidTelefon()
        {
            ErrorMessage = "Telefonnummeret skal...";
        }

        public override bool IsValid(object value)
        {
            string telefon = (int)value;
            if (telefon.length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
