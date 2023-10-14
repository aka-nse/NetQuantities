using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric indactance.
/// This type can be re-interpret-casted into <see cref="double"/> as [H] scale.
/// </summary>
[Quantity]
[QuantityUnit("Henry", "H", 1.0, None | Milli | Micro | Nano | Pico)]
[QuantityOperation(typeof(QElectricIndactance), typeof(QElectricCurrent), typeof(QMagneticFlux))]
public readonly partial struct QElectricIndactance : IQuantity<QElectricIndactance>
{
}
