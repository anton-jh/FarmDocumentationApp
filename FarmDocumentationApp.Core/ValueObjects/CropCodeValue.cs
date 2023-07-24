using FarmDocumentationApp.Core.Validation;
using ValueOf;

namespace FarmDocumentationApp.Core.ValueObjects;
public class CropCodeValue : ValueOf<string, CropCodeValue>
{
    protected override void Validate()
    {
        Value.MustBe().NotEmptyOrWhitespace();
    }
}
