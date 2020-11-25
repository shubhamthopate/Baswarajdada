using Abp.AspNetCore.Mvc.ViewComponents;

namespace CIC_EP.Web.Public.Views
{
    public abstract class CIC_EPViewComponent : AbpViewComponent
    {
        protected CIC_EPViewComponent()
        {
            LocalizationSourceName = CIC_EPConsts.LocalizationSourceName;
        }
    }
}