using FarmDocumentationApp.Core.Exceptions;
using System.Runtime.CompilerServices;

namespace FarmDocumentationApp.Core.Validation;
public abstract class DomainValidator<T>
{
    public DomainValidator(T value, [CallerArgumentExpression("value")] string parameterName = null!)
    {
        ParameterName = parameterName;
        Value = value;
    }

    public T Value { get; }
    public string ParameterName { get; }


    protected void ThrowHelper(string reason)
    {
        throw new DomainValidationException($"Parameter '{ParameterName}' {reason}.");
    }
}
