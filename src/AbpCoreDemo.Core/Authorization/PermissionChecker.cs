using Abp.Authorization;
using AbpCoreDemo.Authorization.Roles;
using AbpCoreDemo.Authorization.Users;
using AbpCoreDemo.MultiTenancy;

namespace AbpCoreDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
