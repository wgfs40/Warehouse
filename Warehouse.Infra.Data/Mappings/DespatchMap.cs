using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain.Models;

namespace Warehouse.Infra.Data.Mappings
{
    public class DespatchMap : IEntityTypeConfiguration<Despatch>
    {
        public void Configure(EntityTypeBuilder<Despatch> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.ItemNumber).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(d => d.Quantity).HasColumnType("int").IsRequired();
            builder.Property(d => d.Date).HasColumnType("datetime").IsRequired();
            builder.Property(d => d.DateModified).HasColumnType("datetime");
            builder.Property(d => d.Username).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(d => d.Company).HasColumnType("nvarchar").HasMaxLength(250);


            //relations
            builder.HasOne(d => d.Items)
                .WithMany(i => i.Despatches)
                .HasForeignKey(d => d.ItemNumber);
                

            builder.ToTable("Despatches");
        }
    }
}
