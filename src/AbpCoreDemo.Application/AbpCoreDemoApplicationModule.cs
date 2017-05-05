using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreDemo.Authorization;

namespace AbpCoreDemo
{
    [DependsOn(
        typeof(AbpCoreDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpCoreDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpCoreDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreDemoApplicationModule).GetAssembly());
        }
    }
}