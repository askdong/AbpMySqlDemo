using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TreeMis.Authorization;

namespace TreeMis
{
    [DependsOn(
        typeof(TreeMisCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TreeMisApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TreeMisAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TreeMisApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
