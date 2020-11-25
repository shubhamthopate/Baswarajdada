using Abp;

namespace CIC_EP
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="CIC_EPDomainServiceBase"/>.
    /// For application services inherit CIC_EPAppServiceBase.
    /// </summary>
    public abstract class CIC_EPServiceBase : AbpServiceBase
    {
        protected CIC_EPServiceBase()
        {
            LocalizationSourceName = CIC_EPConsts.LocalizationSourceName;
        }
    }
}