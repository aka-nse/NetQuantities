using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric charge.
/// This type can be re-interpret-casted into <see cref="double"/> as [C] scale.
/// </summary>
[Quantity]
[QuantityUnit("Coulomb", "C", 1.0, None | Milli | Micro | Nano | Pico)]
[QuantityUnit("AmpareHour", "Ah", 3600, None | Milli | Kilo)]
[QuantityOperation(typeof(QElectricCurrent), typeof(QTime), typeof(QElectricCharge))]
public readonly partial struct QElectricCharge : IQuantity
{
}
