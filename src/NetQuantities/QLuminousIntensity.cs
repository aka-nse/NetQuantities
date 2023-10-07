using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of luminous intensity.
/// This type can be re-interpret-casted into <see cref="double"/> as [cd] scale.
/// </summary>
[Quantity]
[QuantityUnit("Candela", "cd", 1.0, None)]
public readonly partial struct QLuminousIntensity : IQuantity
{
}
