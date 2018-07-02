using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using KS.Configuration;
using KS.Web;

namespace KS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class KSDbContextFactory : IDesignTimeDbContextFactory<KSDbContext>
    {
        public KSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            KSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(KSConsts.ConnectionStringName));

            return new KSDbContext(builder.Options);
        }
    }
}
