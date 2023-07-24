using FarmDocumentationApp.Core.Validation;
using ValueOf;

namespace FarmDocumentationApp.Core.ValueObjects;
public class FertilizerAmount : ValueOf<decimal,  FertilizerAmount>
{
    protected override void Validate()
    {
        Value.MustBe().GreaterThan(0);
    }
}
