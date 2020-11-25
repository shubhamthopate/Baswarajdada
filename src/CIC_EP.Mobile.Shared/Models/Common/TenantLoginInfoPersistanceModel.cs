using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CIC_EP.Sessions.Dto;

namespace CIC_EP.Models.Common
{
    [AutoMapFrom(typeof(TenantLoginInfoDto)),
     AutoMapTo(typeof(TenantLoginInfoDto))]
    public class TenantLoginInfoPersistanceModel : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}