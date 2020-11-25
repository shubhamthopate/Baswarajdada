using System.Threading.Tasks;
using Abp.Application.Services;
using CIC_EP.Sessions.Dto;

namespace CIC_EP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
