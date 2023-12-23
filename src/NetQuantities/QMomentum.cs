using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of momentum or impulse.
/// This type can be re-interpret-casted into <see cref="double"/> as [kg*m/s] scale.
/// </summary>
[Quantity]
[QuantityUnit("GramMetrePerSecond", "g*m/s", 1.0e-3, None | Milli | Micro | Kilo)]
[QuantityUnit("NewtonSecond", "N*s", 1, None | Milli | Kilo)]
[QuantityOperation(typeof(QForce), typeof(QTime), typeof(QMomentum))]
[QuantityOperation(typeof(QMass), typeof(QSpeed), typeof(QMomentum))]
public readonly partial struct QMomentum : IQuantity<QMomentum>
{
}
