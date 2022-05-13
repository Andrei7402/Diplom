using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Menu.EntityFrameworkCore;
using Menu.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Menu.Web.Tests
{
    [DependsOn(
        typeof(MenuWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MenuWebTestModule : AbpModule
    {
        public MenuWebTestModule(MenuEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MenuWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MenuWebMvcModule).Assembly);
        }
    }
}