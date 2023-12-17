using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace SystemeSuiviProjets.Infrastructure
{
    public class SystèmeSuiviProjetsContextFactory : IDesignTimeDbContextFactory<SystèmeSuiviProjetsContext>
    {
        public SystèmeSuiviProjetsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SystèmeSuiviProjetsContext>();
            optionsBuilder.UseSqlServer(@"Server=.;Database=SystèmeSuiviProjetsDB;Trusted_Connection=True;");

            return new SystèmeSuiviProjetsContext(optionsBuilder.Options);
        }
    }
}
