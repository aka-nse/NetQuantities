using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of time.
/// This type can be re-interpret-casted into <see cref="double"/> as [s] scale.
/// </summary>
[Quantity]
[QuantityUnit("Second", "s", 1.0)]
[QuantityUnit("Millisecond", "ms", 1.0e-3)]
[QuantityUnit("Minute", "min", 60.0)]
[QuantityUnit("Hour", "h", 3600.0)]
public readonly partial struct QTime : IQuantity
{
}
