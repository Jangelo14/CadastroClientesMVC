using Microsoft.EntityFrameworkCore;
using SistemaClientes.Models;

namespace SistemaClientes.Data;
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOption<ApplicationDbContext> options) 
        : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ID_Cliente);
        }

    }   
}