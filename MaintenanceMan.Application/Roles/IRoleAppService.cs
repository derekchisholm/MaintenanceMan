using System.Threading.Tasks;
using Abp.Application.Services;
using MaintenanceMan.Roles.Dto;

namespace MaintenanceMan.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
