using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KS.MultiTenancy.Dto;

namespace KS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
