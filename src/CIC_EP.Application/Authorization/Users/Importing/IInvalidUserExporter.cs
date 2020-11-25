using System.Collections.Generic;
using CIC_EP.Authorization.Users.Importing.Dto;
using CIC_EP.Dto;

namespace CIC_EP.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
