using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using openlayerAPI.Configuration;
using openlayerAPI.Web;

namespace openlayerAPI.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class openlayerAPIDbContextFactory : IDesignTimeDbContextFactory<openlayerAPIDbContext>
    {
        public openlayerAPIDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<openlayerAPIDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            openlayerAPIDbContextConfigurer.Configure(builder, configuration.GetConnectionString(openlayerAPIConsts.ConnectionStringName));

            return new openlayerAPIDbContext(builder.Options);
        }
    }
}
