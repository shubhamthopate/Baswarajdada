using System.Threading.Tasks;
using Abp.Application.Services;
using CIC_EP.Configuration.Tenants.Dto;

namespace CIC_EP.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
