using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TreeMis.MultiTenancy.Dto;

namespace TreeMis.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
