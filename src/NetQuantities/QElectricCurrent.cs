using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric current.
/// This type can be re-interpret-casted into <see cref="double"/> as [A] scale.
/// </summary>
[Quantity]
[QuantityUnit("Ampere", "A", 1.0, None | Milli | Micro | Nano | Pico | Kilo, exportsShorthandSymbol: true)]
public readonly partial struct QElectricCurrent : IQuantity<QElectricCurrent>
{
}
