using System;
using System.Numerics;

namespace NetQuantities;

/// <summary>
/// Represents a value of energy.
/// This type can be re-interpret-casted into <see cref="double"/> as [J] scale.
/// </summary>
[Quantity]
[QuantityUnit("Joule", "J", 1.0)]
public readonly partial struct QEnergy : IQuantity
{
}
