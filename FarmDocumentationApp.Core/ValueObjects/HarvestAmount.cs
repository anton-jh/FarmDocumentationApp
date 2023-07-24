using FarmDocumentationApp.Core.Validation;
using ValueOf;

namespace FarmDocumentationApp.Core.ValueObjects;
public class HarvestAmount : ValueOf<decimal, HarvestAmount>
{
    protected override void Validate()
    {
        Value.MustBe().GreaterThan(0);
    }
}
