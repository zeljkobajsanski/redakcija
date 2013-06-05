using System;

namespace Redakcija.Model.Entities
{
    public class Clanak : Entity
    {
        public DateTime Datum { get; set; }

        public string Naslov { get; set; }

        public byte[] Rtf { get; set; }

        public int KreatorID { get; set; }

        public string Pointer { get; set; }

        public Publikacija Publikacija { get; set; }

        public int PublikacijaID { get; set; }

        public Rubrika Rubrika { get; set; }

        public int RubrikaID { get; set; }

    }
}