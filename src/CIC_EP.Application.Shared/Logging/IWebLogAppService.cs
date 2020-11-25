using Abp.Application.Services;
using CIC_EP.Dto;
using CIC_EP.Logging.Dto;

namespace CIC_EP.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
