﻿using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CIC_EP
{
    [DependsOn(typeof(CIC_EPCoreSharedModule))]
    public class CIC_EPApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CIC_EPApplicationSharedModule).GetAssembly());
        }
    }
}