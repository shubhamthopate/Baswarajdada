using System.Threading.Tasks;
using Abp.Application.Services;
using CIC_EP.MultiTenancy.Payments.Dto;
using CIC_EP.MultiTenancy.Payments.Stripe.Dto;

namespace CIC_EP.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}