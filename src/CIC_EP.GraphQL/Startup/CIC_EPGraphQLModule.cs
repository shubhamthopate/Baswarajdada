using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CIC_EP.Startup
{
    [DependsOn(typeof(CIC_EPCoreModule))]
    public class CIC_EPGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CIC_EPGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}