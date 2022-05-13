using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Menu.Configuration.Dto;

namespace Menu.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MenuAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
