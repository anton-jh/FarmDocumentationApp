using System.Runtime.CompilerServices;

namespace FarmDocumentationApp.Core.Validation;
public class DomainValidatorString : DomainValidator<string>
{
    public DomainValidatorString(string value, [CallerArgumentExpression("value")] string parameterName = null!) : base(value, parameterName)
    {
    }


    public DomainValidatorString NotEmptyOrWhitespace()
    {
        if (string.IsNullOrWhiteSpace(Value))
        {
            ThrowHelper("cannot be empty or whitespace");
        }

        return this;
    }

    public DomainValidatorString AtLeastThisLong(int length)
    {
        if (length < 0)
        {
            throw new ArgumentException("A string can't have a negative length now can it?");
        }

        if (Value.Length < length)
        {
            ThrowHelper($"must be at least {length} characters long");
        }

        return this;
    }
}
