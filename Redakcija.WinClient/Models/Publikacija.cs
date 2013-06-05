using System.Collections.Generic;

namespace Redakcija.WinClient.Models
{
    public class Publikacija : Entity
    {
        public Publikacija()
        {
            Rubrike = new List<Rubrika>();
        }

        public string Naziv { get; set; }

        public List<Rubrika> Rubrike { get; set; }
    }
}