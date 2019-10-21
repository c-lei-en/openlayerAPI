using System.Threading.Tasks;
using Abp.Application.Services;
using openlayerAPI.Sessions.Dto;

namespace openlayerAPI.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
