using System.ComponentModel.DataAnnotations;

namespace CIC_EP.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}