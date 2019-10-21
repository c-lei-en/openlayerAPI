using Abp.Application.Services;
using Abp.Application.Services.Dto;
using openlayerAPI.MultiTenancy.Dto;

namespace openlayerAPI.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

