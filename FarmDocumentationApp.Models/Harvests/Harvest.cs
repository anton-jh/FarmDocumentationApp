using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Harvests;
public class Harvest
{
    public required FarmId FarmId { get; init; }
    public required CalendarYear Season { get; init; }
    public required FieldId FieldId { get; init; }
    public required HarvestId Id { get; init; }

    // TODO: HarvestType, HarvestFormat
    public required HarvestAmount Amount { get; init; }

    public Text? Notes { get; set; }
}
