using Abp.Zero.EntityFrameworkCore;
using AbpCoreDemo.Authorization.Roles;
using AbpCoreDemo.Authorization.Users;
using AbpCoreDemo.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace AbpCoreDemo.EntityFrameworkCore
{
    public class AbpCoreDemoDbContext : AbpZeroDbContext<Tenant, Role, User, AbpCoreDemoDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public AbpCoreDemoDbContext(DbContextOptions<AbpCoreDemoDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //...
        }
    }
}
