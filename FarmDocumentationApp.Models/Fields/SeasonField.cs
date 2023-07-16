using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Fields;
public class SeasonField
{
    public required FarmId FarmId { get; init; }
    public required FieldId FieldId { get; init; }
    public required CalendarYear Season { get; init; }

    public required FieldArea Area { get; set; }
    public required FieldGroupId? GroupId { get; set; }
}
