using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of mass.
/// This type can be re-interpret-casted into <see cref="double"/> as [kg] scale.
/// </summary>
[Quantity]
[QuantityUnit("Gram", "g", 1.0e-3, None | Milli | Micro | Kilo, exportsShorthandSymbol: true)]
[QuantityUnit("Tonne", "t", 1.0e+3)]
public readonly partial struct QMass : IQuantity<QMass>
{
}
