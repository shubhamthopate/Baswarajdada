using System.Threading.Tasks;
using CIC_EP.Sessions.Dto;

namespace CIC_EP.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
