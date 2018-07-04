using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain.Models;

namespace Warehouse.Infra.Data.Mappings
{
    public class RecivingMap : IEntityTypeConfiguration<Reciving>
    {
        public void Configure(EntityTypeBuilder<Reciving> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.ItemNumber).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(r => r.Quantity).HasColumnType("int").IsRequired();
            builder.Property(r => r.Price).HasColumnType("decimal").IsRequired();
            builder.Property(r => r.OrderNumber).HasColumnType("nvarchar").HasMaxLength(250);
            builder.Property(r => r.Date).HasColumnType("datetime").IsRequired();
            builder.Property(r => r.DateModified).HasColumnType("datetime");
            builder.Property(r => r.VendorId).HasColumnType("int");
            builder.Property(d => d.Username).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(d => d.Company).HasColumnType("nvarchar").HasMaxLength(250);

            builder.HasOne(d => d.Items)
                .WithMany(i => i.Recivings)
                .HasForeignKey(d => d.ItemNumber);

            builder.HasOne(r => r.vendores)
                .WithMany(v => v.Recivings)
                .HasForeignKey(r => r.VendorId);


            builder.ToTable("Recivings");
        }
    }
}
