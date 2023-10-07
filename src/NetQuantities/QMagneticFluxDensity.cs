using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of magnetic flux density.
/// This type can be re-interpret-casted into <see cref="double"/> as [T] scale.
/// </summary>
[Quantity]
[QuantityUnit("Tesla", "T", 1.0)]
public readonly partial struct QMagneticFluxDensity : IQuantity
{
}