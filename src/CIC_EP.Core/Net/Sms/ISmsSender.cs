using System.Threading.Tasks;

namespace CIC_EP.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}