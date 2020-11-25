using System.Collections.Generic;
using Abp.Application.Services.Dto;
using CIC_EP.Editions.Dto;

namespace CIC_EP.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}