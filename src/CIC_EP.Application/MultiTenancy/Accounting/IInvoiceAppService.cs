using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using CIC_EP.MultiTenancy.Accounting.Dto;

namespace CIC_EP.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
