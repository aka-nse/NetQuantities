using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric capacity.
/// This type can be re-interpret-casted into <see cref="double"/> as [F] scale.
/// </summary>
[Quantity]
[QuantityUnit("Farad", "F", 1.0, None | Milli| Micro | Nano | Pico)]
[QuantityOperation(typeof(QElectricCapacity), typeof(QElectricVoltage), typeof(QElectricCharge))]
public readonly partial struct QElectricCapacity : IQuantity
{
}
