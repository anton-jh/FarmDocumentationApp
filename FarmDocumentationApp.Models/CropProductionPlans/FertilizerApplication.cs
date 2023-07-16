using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.CropProductionPlans;
public class FertilizerApplication
{
    public required FarmId FarmId { get; init; }
    public required CalendarYear Season { get; init; }
    public required FieldId FieldId { get; init; }
    public required FertilizerApplicationId Id { get; init; }

    public required FertilizerTypeId TypeId { get; set; }
    public required FertilizerAmount AmountPerArea { get; set; }
    public required DateOnly Date { get; set; }
    public Text? Notes { get; set; }
}
