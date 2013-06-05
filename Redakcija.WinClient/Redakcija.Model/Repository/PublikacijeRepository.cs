using System.Collections.Generic;
using Redakcija.Model.Entities;
using Redakcija.Model.Interfaces;
using System.Linq;

namespace Redakcija.Model.Repository
{
    public class PublikacijeRepository : RepositoryBase<Publikacija>, IPublikacijeRepository
    {
        public IQueryable<Publikacija> VratiPublikacijeSaRubrikama()
        {
            return DataContext.Publikacije.Include("Rubrike").Where(x => !x.Obrisan);
        }
    }
}