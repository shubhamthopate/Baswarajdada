using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CIC_EP
{
    [DependsOn(typeof(CIC_EPXamarinSharedModule))]
    public class CIC_EPXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CIC_EPXamarinIosModule).GetAssembly());
        }
    }
}