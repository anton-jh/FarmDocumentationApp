using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Farms;
public class Farm
{
    public required FarmId Id { get; init; }

    public required EntityName Name { get; set; }
}
