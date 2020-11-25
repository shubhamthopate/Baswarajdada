using System.Collections.Generic;
using Abp;
using CIC_EP.Chat.Dto;
using CIC_EP.Dto;

namespace CIC_EP.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
