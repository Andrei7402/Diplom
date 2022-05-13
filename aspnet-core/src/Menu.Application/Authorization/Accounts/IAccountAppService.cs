using System.Threading.Tasks;
using Abp.Application.Services;
using Menu.Authorization.Accounts.Dto;

namespace Menu.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
