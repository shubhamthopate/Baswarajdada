using Abp.Auditing;
using CIC_EP.Configuration.Dto;

namespace CIC_EP.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}