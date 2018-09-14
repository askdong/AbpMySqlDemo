using System.Threading.Tasks;
using Abp.Application.Services;
using TreeMis.Authorization.Accounts.Dto;

namespace TreeMis.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
