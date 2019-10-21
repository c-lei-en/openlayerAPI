using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using openlayerAPI.Configuration;

namespace openlayerAPI.Web.Host.Startup
{
    [DependsOn(
       typeof(openlayerAPIWebCoreModule))]
    public class openlayerAPIWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public openlayerAPIWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(openlayerAPIWebHostModule).GetAssembly());
        }
    }
}
