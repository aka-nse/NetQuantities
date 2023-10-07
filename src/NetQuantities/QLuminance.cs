using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of luminance.
/// This type can be re-interpret-casted into <see cref="double"/> as [cd/m^2] scale.
/// </summary>
[Quantity]
[QuantityUnit("CandelaPerSquareMetre", "cd/m^2", 1.0)]
[QuantityOperation(typeof(QArea), typeof(QLuminance), typeof(QLuminousIntensity))]
public readonly partial struct QLuminance : IQuantity
{
}
