using System.Threading.Tasks;
using Abp.Application.Services;
using Menu.Sessions.Dto;

namespace Menu.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
