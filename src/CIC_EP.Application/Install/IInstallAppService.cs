using System.Threading.Tasks;
using Abp.Application.Services;
using CIC_EP.Install.Dto;

namespace CIC_EP.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}