using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Redakcija.Model.Entities;
using Redakcija.Model.Interfaces;

namespace Redakcija.Model.Repository.Fake
{
    public class PublikacijeRepository : IPublikacijeRepository
    {
        public void Add(Publikacija entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Publikacija entity)
        {
            throw new System.NotImplementedException();
        }

        public Publikacija Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Publikacija> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Publikacija> VratiPublikacijeSaRubrikama()
        {
            return new List<Publikacija>
            {
                new Publikacija{ID = 1, Naziv = "Dnevnik", Rubrike = new Collection<Rubrika>()
                {
                    new Rubrika(){ID = 1, Naziv = "Politika"},
                    new Rubrika(){ID = 2, Naziv = "Svet"},
                    new Rubrika(){ID = 3, Naziv = "Kultura"},
                }},
                new Publikacija{ID = 2, Naziv = "Lovac", Rubrike = new Collection<Rubrika>()
                {
                    new Rubrika(){ID = 4, Naziv = "Lov"},
                    new Rubrika(){ID = 5, Naziv = "Ribolov"},
                }}
            }.AsQueryable();
        }
    }
}