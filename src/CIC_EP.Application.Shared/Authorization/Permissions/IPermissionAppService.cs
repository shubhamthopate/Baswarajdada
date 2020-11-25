using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CIC_EP.Authorization.Permissions.Dto;

namespace CIC_EP.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
