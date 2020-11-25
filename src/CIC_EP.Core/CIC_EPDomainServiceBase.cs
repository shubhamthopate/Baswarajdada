using Abp.Domain.Services;

namespace CIC_EP
{
    public abstract class CIC_EPDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected CIC_EPDomainServiceBase()
        {
            LocalizationSourceName = CIC_EPConsts.LocalizationSourceName;
        }
    }
}
