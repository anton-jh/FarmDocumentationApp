﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOf;

namespace FarmDocumentationApp.Core.Ids;
public class GuidId<T> : ValueOf<Guid, T>
    where T : ValueOf<Guid, T>, new()
{
    public T NewId() =>
        From(Guid.NewGuid());
}
