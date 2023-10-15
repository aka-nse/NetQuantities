using System;
using System.Numerics;

namespace NetQuantities;

/// <summary>
/// Represents a value of dimensionless.
/// This type can be re-interpret-casted into <see cref="double"/> as [1] scale.
/// </summary>
[Quantity]
[QuantityUnit("Raw", "1", 1)]
public readonly partial struct QDimensionless : IQuantity
{
}
