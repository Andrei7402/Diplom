using Abp.Authorization;
using Menu.Authorization.Roles;
using Menu.Authorization.Users;

namespace Menu.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
