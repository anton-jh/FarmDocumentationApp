using FarmDocumentationApp.Core.Ids;

namespace FarmDocumentationApp.Models.Fields;
public class Field
{
    public required FarmId FarmId { get; init; }
    public required FieldId Id { get; init; }

    public required string Name { get; set; }
    public required string Code { get; set; }
}
