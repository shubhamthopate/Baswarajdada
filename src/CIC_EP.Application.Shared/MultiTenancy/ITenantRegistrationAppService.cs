using System.Threading.Tasks;
using Abp.Application.Services;
using CIC_EP.Editions.Dto;
using CIC_EP.MultiTenancy.Dto;

namespace CIC_EP.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}