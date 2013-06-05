using System.Collections.Generic;

namespace Redakcija.Model.Entities
{
    public class Publikacija : Entity
    {
        public string Naziv { get; set; }

        public ICollection<Rubrika> Rubrike { get; set; }
    }
}