 using ITMCode.Piatnica.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Dampak.Api
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PiatnicaContext>
    {
        public PiatnicaContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<PiatnicaContext>();
            var connectionString = configuration.GetConnectionString("Piatnica");
            builder.UseSqlServer(connectionString, x => x.MigrationsAssembly("ITMCode.Piatnica.Api"));
            return new PiatnicaContext(builder.Options);
        }
    }
}