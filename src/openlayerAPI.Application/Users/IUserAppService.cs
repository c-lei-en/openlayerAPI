using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using openlayerAPI.Roles.Dto;
using openlayerAPI.Users.Dto;

namespace openlayerAPI.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
