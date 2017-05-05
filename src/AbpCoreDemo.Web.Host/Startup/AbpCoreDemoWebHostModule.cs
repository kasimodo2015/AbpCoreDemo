using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreDemo.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AbpCoreDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpCoreDemoWebCoreModule))]
    public class AbpCoreDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpCoreDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreDemoWebHostModule).GetAssembly());
        }
    }
}
