using System.Threading.Tasks;
using CIC_EP.Security.Recaptcha;

namespace CIC_EP.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
