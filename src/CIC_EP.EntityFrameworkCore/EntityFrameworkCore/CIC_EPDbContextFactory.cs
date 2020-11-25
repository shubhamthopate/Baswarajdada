using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CIC_EP.Configuration;
using CIC_EP.Web;

namespace CIC_EP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CIC_EPDbContextFactory : IDesignTimeDbContextFactory<CIC_EPDbContext>
    {
        public CIC_EPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CIC_EPDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            CIC_EPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CIC_EPConsts.ConnectionStringName));

            return new CIC_EPDbContext(builder.Options);
        }
    }
}