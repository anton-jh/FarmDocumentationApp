using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.CropProductionPlans;
public class Seeding
{
    public required FarmId FarmId { get; init; }
    public required CalendarYear Season { get; init; }
    public required FieldId FieldId { get; init; }
    public required SeedTypeId SeedTypeId { get; init; }

    public required SeedAmount Amount { get; init; }
}
