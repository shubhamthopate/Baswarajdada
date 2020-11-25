using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CIC_EP.Authorization;

namespace CIC_EP
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(CIC_EPApplicationSharedModule),
        typeof(CIC_EPCoreModule)
        )]
    public class CIC_EPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CIC_EPApplicationModule).GetAssembly());
        }
    }
}