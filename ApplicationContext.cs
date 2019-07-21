using CrudRapido.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudRapido
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pessoa>().HasKey(t => t.Id);
        }
    }
}