using FarmDocumentationApp.Core.Ids;

namespace FarmDocumentationApp.Core.ValueObjects;
public class HarvestInformation
{
    public required FieldId FieldId { get; init; }
    public required CalendarYear Season { get; init; }
    public required DateOnly HarvestDate { get; init; }
}
