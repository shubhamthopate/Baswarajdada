using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CIC_EP.Authorization.Users.Dto;

namespace CIC_EP.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
