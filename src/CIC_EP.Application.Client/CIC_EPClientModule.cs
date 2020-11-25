using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CIC_EP
{
    public class CIC_EPClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CIC_EPClientModule).GetAssembly());
        }
    }
}
