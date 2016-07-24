using Abp.Authorization;
using MaintenanceMan.Authorization.Roles;
using MaintenanceMan.MultiTenancy;
using MaintenanceMan.Users;

namespace MaintenanceMan.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
