using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KS.Authorization;

namespace KS
{
    [DependsOn(
        typeof(KSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<KSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(KSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
