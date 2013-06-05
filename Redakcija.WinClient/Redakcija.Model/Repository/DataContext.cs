using System.Data.Entity;
using Redakcija.Model.Entities;

namespace Redakcija.Model.Repository
{
    public class DataContext : DbContext
    {
        public DbSet<Publikacija> Publikacije { get; set; }

        public DbSet<Rubrika> Rubrike { get; set; }

        public DbSet<Clanak> Clanci { get; set; }
    }
}