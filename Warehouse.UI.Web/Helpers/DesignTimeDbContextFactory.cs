using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using Warehouse.Infra.Data.Context;

namespace Warehouse.UI.Web
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WirehouseContext>
    {
        public WirehouseContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<WirehouseContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new WirehouseContext();
        }
    }
}
