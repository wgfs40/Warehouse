using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Warehouse.Domain.Models;
using Warehouse.Infra.Data.Mappings;

namespace Warehouse.Infra.Data.Context
{
    public class WirehouseContext : DbContext
    {
        public WirehouseContext(DbContextOptions<WirehouseContext> options):
            base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Despatch> Despatches { get; set; }
        public DbSet<Reciving> Recivings { get; set; }
        public DbSet<Vendor> Vendores { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemMap());
            modelBuilder.ApplyConfiguration(new DespatchMap());
            modelBuilder.ApplyConfiguration(new RecivingMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());            

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

    }
}
