namespace Redakcija.Web.Models
{
    public class Publikacija
    {
        public Publikacija()
        {
            Rubrike = new Rubrika[0];
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public Rubrika[] Rubrike { get; set; }
    }
}