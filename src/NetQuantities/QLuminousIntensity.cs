using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of luminous intensity.
/// This type can be re-interpret-casted into <see cref="double"/> as [cd] scale.
/// </summary>
[Quantity]
[QuantityUnit("Candela", "cd", 1.0)]
public readonly partial struct QLuminousIntensity : IQuantity
{
}
