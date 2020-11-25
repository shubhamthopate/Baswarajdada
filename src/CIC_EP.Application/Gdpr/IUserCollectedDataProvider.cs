using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using CIC_EP.Dto;

namespace CIC_EP.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
