using System;
using static NetQuantities.UnitPrefix;
namespace NetQuantities;

/// <summary>
/// Represents a value of length.
/// This type can be re-interpret-casted into <see cref="double"/> as [m] scale.
/// </summary>
[Quantity]
[QuantityUnit("Metre", "m", 1.0, None | Centi | Milli | Micro | Nano | Kilo, exportsShorthandSymbol: true)]
public readonly partial struct QLength : IQuantity<QLength>
{
}
