using System.Threading.Tasks;
using Abp.Application.Services;
using CIC_EP.Configuration.Host.Dto;

namespace CIC_EP.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
