using System.Threading.Tasks;
using Abp.Application.Services;
using CIC_EP.MultiTenancy.Payments.PayPal.Dto;

namespace CIC_EP.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
