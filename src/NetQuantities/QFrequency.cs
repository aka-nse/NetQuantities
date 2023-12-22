using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of frequency.
/// This type can be re-interpret-casted into <see cref="double"/> as [Hz] scale.
/// </summary>
[Quantity]
[QuantityUnit("Hertz", "Hz", 1.0, None | Kilo | Mega | Giga | Tera, exportsShorthandSymbol: true)]
[QuantityOperation(typeof(QTime), typeof(QFrequency), typeof(QDimensionless))]
public readonly partial struct QFrequency : IQuantity<QFrequency>
{
}
