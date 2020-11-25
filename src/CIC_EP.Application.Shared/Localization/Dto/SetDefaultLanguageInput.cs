using System.ComponentModel.DataAnnotations;
using Abp.Localization;

namespace CIC_EP.Localization.Dto
{
    public class SetDefaultLanguageInput
    {
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public virtual string Name { get; set; }
    }
}