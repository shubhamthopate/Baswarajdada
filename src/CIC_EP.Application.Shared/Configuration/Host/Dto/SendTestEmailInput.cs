using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;

namespace CIC_EP.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}