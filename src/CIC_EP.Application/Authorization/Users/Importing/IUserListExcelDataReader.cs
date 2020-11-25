using System.Collections.Generic;
using CIC_EP.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace CIC_EP.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
