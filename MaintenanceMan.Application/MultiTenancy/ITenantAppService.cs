using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MaintenanceMan.MultiTenancy.Dto;

namespace MaintenanceMan.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
