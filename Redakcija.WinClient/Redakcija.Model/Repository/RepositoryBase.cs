using System.Data;
using Redakcija.Model.Entities;
using System.Linq;
using Redakcija.Model.Interfaces;

namespace Redakcija.Model.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
    {
        protected DataContext DataContext = new DataContext();

        public void Add(T entity)
        {
            DataContext.Set<T>().Add(entity);
        }    

        public void Update(T entity)
        {
            DataContext.Entry(entity).State = EntityState.Modified;
        }

        public T Get(int id)
        {
            return DataContext.Set<T>().SingleOrDefault(x => x.ID == id);
        }

        public IQueryable<T> GetAll()
        {
            return DataContext.Set<T>().Where(x => !x.Obrisan);
        }
    }
}