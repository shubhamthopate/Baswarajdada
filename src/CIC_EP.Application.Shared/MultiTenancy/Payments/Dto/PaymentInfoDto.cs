using CIC_EP.Editions.Dto;

namespace CIC_EP.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < CIC_EPConsts.MinimumUpgradePaymentAmount;
        }
    }
}
