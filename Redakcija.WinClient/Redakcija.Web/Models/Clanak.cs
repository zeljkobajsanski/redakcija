using System;

namespace Redakcija.Web.Models
{
    public class Clanak
    {
        public int KreatorID { get; set; }
        public int PublikacijaID { get; set; }
        public int RubrikaID { get; set; }
        public DateTime Datum { get; set; }
        public string Naslov { get; set; }
        public byte[] Raw { get; set; } 
    }
}