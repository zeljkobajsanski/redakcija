using System.Linq;
using Redakcija.Model.Entities;

namespace Redakcija.Model.Interfaces
{
    public interface IRepositoryBase<T> where T : Entity
    {
        void Add(T entity);
        void Update(T entity);
        T Get(int id);
        IQueryable<T> GetAll();
    }
}