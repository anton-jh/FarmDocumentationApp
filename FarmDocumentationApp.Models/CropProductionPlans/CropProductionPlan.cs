using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.CropProductionPlans;
public class CropProductionPlan
{
    public required FarmId FarmId { get; init; }
    public required CalendarYear Season { get; init; }
    public required FieldId FieldId { get; init; }

    public CropId? PreviousCropId { get; set; }
    public CropRotationId? PreviousCropRotationId { get; set; }
    public Ordinal? PreviousCropRotationStep { get; set; }

    public CropId? CurrentCropId { get; set; }
    public CropRotationId? CurrentCropRotationId { get; set; }
    public Ordinal? CurrentCropRotationStep { get; set; }

    public DateOnly? SeedingDate { get; init; }

    public Text? Notes { get; set; }
}
