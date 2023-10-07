using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of magnetic flux.
/// This type can be re-interpret-casted into <see cref="double"/> as [Wb] scale.
/// </summary>
[Quantity]
[QuantityUnit("Weber", "Wb", 1.0)]
public readonly partial struct QMagneticFlux : IQuantity
{
}
