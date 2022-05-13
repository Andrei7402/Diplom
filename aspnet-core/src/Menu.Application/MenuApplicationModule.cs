using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Menu.Authorization;

namespace Menu
{
    [DependsOn(
        typeof(MenuCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MenuApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MenuAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MenuApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
