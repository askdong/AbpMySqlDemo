using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TreeMis.Roles.Dto;
using TreeMis.Users.Dto;

namespace TreeMis.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
