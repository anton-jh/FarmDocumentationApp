using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Crops;
public class Crop
{
    public required FarmId FarmId { get; init; }
    public required CropId Id { get; init; }

    public required EntityName Name { get; set; }
}
