namespace Redakcija.Model.Entities
{
    public class Rubrika : Entity
    {
        public string Naziv { get; set; }

        public Publikacija Publikacija { get; set; }

        public int PublikacijaID { get; set; }
    }
}