using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOf;
using FarmDocumentationApp.Core.Validation;

namespace FarmDocumentationApp.Core.ValueObjects;
public class FieldArea : ValueOf<decimal, FieldArea>
{
    protected override void Validate()
    {
        Value.MustBe().GreaterThan(0);
    }
}
