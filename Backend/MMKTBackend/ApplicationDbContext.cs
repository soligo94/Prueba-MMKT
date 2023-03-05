using Microsoft.EntityFrameworkCore;
using MMKTBackend.Domain;
using System.Reflection.Emit;

namespace MMKTBackend.API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Producto");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Producto> Productos { get; set; }
    }
}
