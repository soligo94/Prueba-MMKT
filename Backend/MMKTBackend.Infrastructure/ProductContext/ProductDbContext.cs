using Microsoft.EntityFrameworkCore;
using MMKTBackend.Domain;
using System.Reflection.Emit;

namespace MMKTBackend.Infrastructure.ProductContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Product>().ToTable("Product");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Domain.Entities.Product> Products { get; set; }
    }
}
