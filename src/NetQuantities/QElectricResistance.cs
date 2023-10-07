using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric resistance.
/// This type can be re-interpret-casted into <see cref="double"/> as [Ω] scale.
/// </summary>
[Quantity]
[QuantityUnit("Ohm", "Ω", 1.0, None | Milli | Kilo | Mega | Giga)]
[QuantityOperation(typeof(QElectricCurrent), typeof(QElectricResistance), typeof(QElectricVoltage))]
public readonly partial struct QElectricResistance : IQuantity
{
}
