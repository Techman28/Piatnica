using Piatnica.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ITMCode.Piatnica.Dal.ConsoleApp
{

    public class PiatnicaContextFactory : IDesignTimeDbContextFactory<PiatnicaContext>
    {
        public PiatnicaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PiatnicaContext>();
            optionsBuilder.UseSqlite("Data Source=Piatnica.db");

            return new PiatnicaContext(optionsBuilder.Options);
        }
    }

}
