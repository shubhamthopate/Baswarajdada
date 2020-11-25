using Abp.AspNetCore.Mvc.Views;

namespace CIC_EP.Web.Views
{
    public abstract class CIC_EPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected CIC_EPRazorPage()
        {
            LocalizationSourceName = CIC_EPConsts.LocalizationSourceName;
        }
    }
}
