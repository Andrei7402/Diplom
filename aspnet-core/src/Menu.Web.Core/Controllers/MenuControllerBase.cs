using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Menu.Controllers
{
    public abstract class MenuControllerBase: AbpController
    {
        protected MenuControllerBase()
        {
            LocalizationSourceName = MenuConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
