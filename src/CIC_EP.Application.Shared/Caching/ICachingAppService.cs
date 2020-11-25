using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CIC_EP.Caching.Dto;

namespace CIC_EP.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
