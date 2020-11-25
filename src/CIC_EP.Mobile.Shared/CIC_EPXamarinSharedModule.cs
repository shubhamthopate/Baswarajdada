using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CIC_EP
{
    [DependsOn(typeof(CIC_EPClientModule), typeof(AbpAutoMapperModule))]
    public class CIC_EPXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CIC_EPXamarinSharedModule).GetAssembly());
        }
    }
}