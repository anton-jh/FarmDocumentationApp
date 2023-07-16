using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.CropRotations;
public class CropRotation
{
    public required FarmId FarmId { get; init; }
    public required CalendarYear Season { get; init; }
    public required CropRotationId Id { get; init; }

    public required EntityName Name { get; set; }
}
