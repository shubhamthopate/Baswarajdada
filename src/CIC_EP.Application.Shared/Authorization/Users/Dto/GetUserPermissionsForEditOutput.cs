using System.Collections.Generic;
using CIC_EP.Authorization.Permissions.Dto;

namespace CIC_EP.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}