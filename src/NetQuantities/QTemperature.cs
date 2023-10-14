using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of thermodynamic temperature.
/// This type can be re-interpret-casted into <see cref="double"/> as [K] scale.
/// </summary>
[Quantity]
[QuantityUnit("Kelvin", "K", 1.0)]
public readonly partial struct QTemperature : IQuantity<QTemperature>
{
}
