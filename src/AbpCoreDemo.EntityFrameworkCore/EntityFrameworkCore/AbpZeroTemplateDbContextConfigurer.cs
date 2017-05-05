using Microsoft.EntityFrameworkCore;

namespace AbpCoreDemo.EntityFrameworkCore
{
    public static class AbpCoreDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpCoreDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}