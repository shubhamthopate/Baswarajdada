using System.Threading.Tasks;
using Abp.Webhooks;

namespace CIC_EP.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
