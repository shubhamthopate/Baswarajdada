using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace CIC_EP.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
