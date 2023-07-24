using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.CropProductionPlans;
public class FertilizerType
{
    public required FarmId FarmId { get; init; }
    public required FertilizerTypeId Id { get; init; }

    public required EntityName Name { get; set; }
    public required UnitDefinition Unit { get; set; }
}
