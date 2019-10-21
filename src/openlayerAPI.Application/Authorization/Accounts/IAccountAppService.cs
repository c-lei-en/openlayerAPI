using System.Threading.Tasks;
using Abp.Application.Services;
using openlayerAPI.Authorization.Accounts.Dto;

namespace openlayerAPI.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
