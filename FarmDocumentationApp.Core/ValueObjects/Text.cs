using FarmDocumentationApp.Core.Validation;
using ValueOf;

namespace FarmDocumentationApp.Core.ValueObjects;
public class Text : ValueOf<string, Text>
{
    protected override void Validate()
    {
        Value.MustBe().NotEmptyOrWhitespace();
    }
}
