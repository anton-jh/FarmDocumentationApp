using ValueOf;

namespace FarmDocumentationApp.Core.ValueObjects;
public class Ordinal : ValueOf<int, Ordinal>
{
    public static Ordinal First()
        => From(1);

    public static Ordinal Before(Ordinal other)
        => From(other.Value - 1);

    public static Ordinal After(Ordinal other)
        => From(other.Value + 1);

    public static Ordinal Between(Ordinal afterThis, Ordinal beforeThis)
        => From((beforeThis.Value - afterThis.Value) / 2 + afterThis.Value);
}
