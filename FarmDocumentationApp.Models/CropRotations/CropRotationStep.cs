using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.CropRotations;
public class CropRotationStep
{
    public required FarmId FarmId { get; init; }
    public required CalendarYear Season { get; init; }
    public required CropRotationId CropRotationId { get; init; }
    public required Ordinal Ordinal { get; init; }

    public required CropId CropId { get; set; }
}
