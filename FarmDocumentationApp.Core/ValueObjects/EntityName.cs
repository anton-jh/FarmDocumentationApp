using FarmDocumentationApp.Core.Validation;
using ValueOf;

namespace FarmDocumentationApp.Core.ValueObjects;
public class EntityName : ValueOf<string, EntityName>
{
    protected override void Validate()
    {
        Value.MustBe().NotEmptyOrWhitespace();
    }
}
