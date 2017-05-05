using AbpCoreDemo.Configuration;
using AbpCoreDemo.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace AbpCoreDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpCoreDemoDbContextFactory : IDbContextFactory<AbpCoreDemoDbContext>
    {
        public AbpCoreDemoDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<AbpCoreDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpCoreDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpCoreDemoConsts.ConnectionStringName));
            
            return new AbpCoreDemoDbContext(builder.Options);
        }
    }
}