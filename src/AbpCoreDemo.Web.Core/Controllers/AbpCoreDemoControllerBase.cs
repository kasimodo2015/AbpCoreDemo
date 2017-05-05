using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpCoreDemo.Controllers
{
    public abstract class AbpCoreDemoControllerBase: AbpController
    {
        protected AbpCoreDemoControllerBase()
        {
            LocalizationSourceName = AbpCoreDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}