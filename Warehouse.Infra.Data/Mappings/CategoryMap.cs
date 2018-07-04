using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain.Models;

namespace Warehouse.Infra.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Description).HasColumnType("nvarchar").HasMaxLength(360).IsRequired();
            builder.Property(c => c.Company).HasColumnType("nvarchar").HasMaxLength(250);

            //relation
            builder.HasMany(i => i.Items);

            builder.ToTable("Categories");
        }
    }
}
