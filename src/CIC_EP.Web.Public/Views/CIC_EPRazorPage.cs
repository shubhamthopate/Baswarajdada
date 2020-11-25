using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CIC_EP.Web.Public.Views
{
    public abstract class CIC_EPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CIC_EPRazorPage()
        {
            LocalizationSourceName = CIC_EPConsts.LocalizationSourceName;
        }
    }
}
