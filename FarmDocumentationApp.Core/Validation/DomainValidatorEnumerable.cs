using System.Runtime.CompilerServices;

namespace FarmDocumentationApp.Core.Validation;
public class DomainValidatorEnumerable<T> : DomainValidator<IEnumerable<T>>
{
    public DomainValidatorEnumerable(IEnumerable<T> value, [CallerArgumentExpression("value")] string parameterName = null!) : base(value, parameterName)
    {
    }


    public DomainValidatorEnumerable<T> NotEmpty()
    {
        if (Value.Any() == false)
        {
            ThrowHelper("cannot be empty");
        }

        return this;
    }
}
