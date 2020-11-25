using System.Threading.Tasks;
using CIC_EP.Authorization.Users;

namespace CIC_EP.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
