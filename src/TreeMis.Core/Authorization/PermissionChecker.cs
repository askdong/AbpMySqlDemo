using Abp.Authorization;
using TreeMis.Authorization.Roles;
using TreeMis.Authorization.Users;

namespace TreeMis.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
