using Abp.Authorization;
using KS.Authorization.Roles;
using KS.Authorization.Users;

namespace KS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
