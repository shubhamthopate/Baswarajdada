using System;
using CIC_EP.Core;
using CIC_EP.Core.Dependency;
using CIC_EP.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CIC_EP.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}