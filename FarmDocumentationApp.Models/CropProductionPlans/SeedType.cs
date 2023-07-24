using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.CropProductionPlans;
public class SeedType
{
    public required FarmId FarmId { get; init; }
    public required SeedTypeId Id { get; init; }
    
    public required EntityName Name { get; set; }
    public CropId? ResultingCrop { get; set; }
}
