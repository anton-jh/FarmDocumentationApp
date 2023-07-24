using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Farms;
public class Season
{
    public required FarmId FarmId { get; init; }
    public required CalendarYear Year { get; init; }

    public Text? Notes { get; set; }
}
