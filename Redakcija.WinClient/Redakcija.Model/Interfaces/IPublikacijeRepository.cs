using System.Collections.Generic;
using System.Linq;
using Redakcija.Model.Entities;

namespace Redakcija.Model.Interfaces
{
    public interface IPublikacijeRepository : IRepositoryBase<Publikacija>
    {
        IQueryable<Publikacija> VratiPublikacijeSaRubrikama();
    }
}