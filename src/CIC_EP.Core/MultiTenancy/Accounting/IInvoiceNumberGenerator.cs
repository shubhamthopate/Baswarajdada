using System.Threading.Tasks;
using Abp.Dependency;

namespace CIC_EP.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}