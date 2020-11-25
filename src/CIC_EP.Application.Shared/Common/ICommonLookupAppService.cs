using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CIC_EP.Common.Dto;
using CIC_EP.Editions.Dto;

namespace CIC_EP.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}