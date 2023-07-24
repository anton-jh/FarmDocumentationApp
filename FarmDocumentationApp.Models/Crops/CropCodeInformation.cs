using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Crops;
public class CropCodeInformation
{
    public required CalendarYear Year { get; init; }
    public required CropCodeValue CropCodeValue { get; init; }
    
    public required Text Key { get; init; }
    public Text? Value { get; set; }
}
