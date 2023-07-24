using FarmDocumentationApp.Core.Validation;

namespace FarmDocumentationApp.Core.ValueObjects;
public record UnitDefinition
{
    public UnitDefinition(string singular, string plural)
    {
        singular.MustBe().AtLeastThisLong(1);
        plural.MustBe().AtLeastThisLong(1);

        Singular = singular;
        Plural = plural;
    }


    public string Singular { get; }
    public string Plural { get; }
}
