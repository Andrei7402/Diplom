using System.Threading.Tasks;
using Menu.Configuration.Dto;

namespace Menu.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
