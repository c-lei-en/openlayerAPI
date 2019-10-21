using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using openlayerAPI.Authorization;

namespace openlayerAPI
{
    [DependsOn(
        typeof(openlayerAPICoreModule), 
        typeof(AbpAutoMapperModule))]
    public class openlayerAPIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<openlayerAPIAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(openlayerAPIApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
