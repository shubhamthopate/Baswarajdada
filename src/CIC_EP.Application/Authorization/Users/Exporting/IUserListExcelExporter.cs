using System.Collections.Generic;
using CIC_EP.Authorization.Users.Dto;
using CIC_EP.Dto;

namespace CIC_EP.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}