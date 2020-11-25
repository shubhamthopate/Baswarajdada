using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using CIC_EP.Configure;
using CIC_EP.Startup;
using CIC_EP.Test.Base;

namespace CIC_EP.GraphQL.Tests
{
    [DependsOn(
        typeof(CIC_EPGraphQLModule),
        typeof(CIC_EPTestBaseModule))]
    public class CIC_EPGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CIC_EPGraphQLTestModule).GetAssembly());
        }
    }
}