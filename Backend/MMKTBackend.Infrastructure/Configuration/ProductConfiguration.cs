using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MMKTBackend.Domain.Entities;


namespace MMKTBackend.Infrastructure.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<MMKTBackend.Domain.Entities.Product>
    {
        public void Configure(EntityTypeBuilder<MMKTBackend.Domain.Entities.Product> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(180);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Family).IsRequired();
        }
    }
}
