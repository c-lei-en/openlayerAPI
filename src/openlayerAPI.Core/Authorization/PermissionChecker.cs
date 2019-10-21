using Abp.Authorization;
using openlayerAPI.Authorization.Roles;
using openlayerAPI.Authorization.Users;

namespace openlayerAPI.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
