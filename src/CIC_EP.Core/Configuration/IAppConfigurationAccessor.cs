using Microsoft.Extensions.Configuration;

namespace CIC_EP.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
