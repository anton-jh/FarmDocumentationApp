using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Crops;
public class SeasonCrop
{
    public required FarmId FarmId { get; init; }
    public required CalendarYear Season { get; init; }
    public required CropId CropId { get; init; }

    public required CropCodeValue CropCode { get; set; }
}
