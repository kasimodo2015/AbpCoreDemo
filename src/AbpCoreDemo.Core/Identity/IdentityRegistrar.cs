using AbpCoreDemo.Authorization.Roles;
using AbpCoreDemo.Authorization.Users;
using AbpCoreDemo.MultiTenancy;
using Microsoft.Extensions.DependencyInjection;

namespace AbpCoreDemo.Identity
{
    public static class IdentityRegistrar
    {
        public static void Register(ServiceCollection services)
        {
            services.AddLogging();

            services.AddAbpIdentity<Tenant, User, Role, SecurityStampValidator>(options =>
                {
                    options.Cookies.ApplicationCookie.AuthenticationScheme = "AbpZeroTemplateAuthSchema";
                    options.Cookies.ApplicationCookie.CookieName = "AbpZeroTemplateAuth";
                })
                .AddUserManager<UserManager>()
                .AddRoleManager<RoleManager>()
                .AddSignInManager<SignInManager>()
                .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddDefaultTokenProviders();
        }
    }
}
