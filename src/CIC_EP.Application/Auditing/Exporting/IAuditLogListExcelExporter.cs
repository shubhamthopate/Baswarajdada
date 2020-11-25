using System.Collections.Generic;
using CIC_EP.Auditing.Dto;
using CIC_EP.Dto;

namespace CIC_EP.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
