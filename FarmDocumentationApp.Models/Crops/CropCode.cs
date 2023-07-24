using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Crops;
public class CropCode
{
    public required CalendarYear Year { get; init; }
    public required CropCodeValue Code { get; init; }

    public required EntityName Name { get; set; }
}
