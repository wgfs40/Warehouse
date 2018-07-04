using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain.Models;

namespace Warehouse.Infra.Data.Mappings
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.ItemNumber).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(i => i.Location).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(i => i.Description).HasColumnType("nvarchar").HasMaxLength(400).IsRequired();
            builder.Property(i => i.PartNumber).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(i => i.IDVendor).HasColumnType("int").IsRequired();
            builder.Property(i => i.Quantity).HasColumnType("int").IsRequired();
            builder.Property(i => i.UM).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(i => i.Max).HasColumnType("int").IsRequired();
            builder.Property(i => i.Min).HasColumnType("int").IsRequired();
            builder.Property(d => d.Username).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(d => d.Company).HasColumnType("nvarchar").HasMaxLength(250);
            builder.Property(i => i.DateCreated).HasColumnType("datetime").IsRequired();
            builder.Property(i => i.DateModified).HasColumnType("datetime");

            builder.HasMany(i => i.Despatches);
            builder.HasMany(i => i.Recivings);

            builder.HasOne(i => i.Vendores)
                .WithMany(v => v.Items)
                .HasForeignKey(i => i.IDVendor);

            builder.HasOne(i => i.Categories)
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.CategoryID);

            builder.ToTable("Items");
        }
    }
}
