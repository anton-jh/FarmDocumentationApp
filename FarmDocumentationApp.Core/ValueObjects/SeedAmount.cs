using FarmDocumentationApp.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOf;

namespace FarmDocumentationApp.Core.ValueObjects;
public class SeedAmount : ValueOf<decimal, SeedAmount>
{
    protected override void Validate()
    {
        Value.MustBe().GreaterThan(0);
    }
}
