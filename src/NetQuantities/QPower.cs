using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of power.
/// This type can be re-interpret-casted into <see cref="double"/> as [W] scale.
/// </summary>
[Quantity]
[QuantityUnit("Watt", "W", 1.0, None | Milli | Micro | Nano | Pico | Femto | Kilo | Mega | Giga | Tera | Peta, exportsShorthandSymbol: true)]
[QuantityOperation(typeof(QTime), typeof(QPower), typeof(QEnergy))]
[QuantityOperation(typeof(QElectricCurrent), typeof(QElectricVoltage), typeof(QPower))]
public readonly partial struct QPower : IQuantity<QPower>
{
}
