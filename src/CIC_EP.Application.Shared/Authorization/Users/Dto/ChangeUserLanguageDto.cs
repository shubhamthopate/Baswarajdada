using System.ComponentModel.DataAnnotations;

namespace CIC_EP.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
