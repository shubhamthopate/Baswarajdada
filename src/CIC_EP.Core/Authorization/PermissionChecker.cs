using Abp.Authorization;
using CIC_EP.Authorization.Roles;
using CIC_EP.Authorization.Users;

namespace CIC_EP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
