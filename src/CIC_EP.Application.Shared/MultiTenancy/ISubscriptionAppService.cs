using System.Threading.Tasks;
using Abp.Application.Services;

namespace CIC_EP.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
