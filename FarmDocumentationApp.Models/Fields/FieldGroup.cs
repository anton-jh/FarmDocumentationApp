using FarmDocumentationApp.Core.Ids;
using FarmDocumentationApp.Core.ValueObjects;

namespace FarmDocumentationApp.Models.Fields;
public class FieldGroup
{
    public required FarmId FarmId { get; init; }
    public required FieldGroupId Id { get; init; }
    
    public required EntityName Name { get; set; }
}
