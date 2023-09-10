using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace NetQuantities;

[Quantity]
[QuantityUnit("Second", "s", 1.0)]
[QuantityUnit("Millisecond", "ms", 1.0e-3)]
[QuantityUnit("Minute", "min", 60.0)]
[QuantityUnit("Hour", "h", 3600.0)]
public readonly partial struct QTime
    : IQuantity
{
}
