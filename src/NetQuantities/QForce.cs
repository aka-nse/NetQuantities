using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of mechanical force.
/// This type can be re-interpret-casted into <see cref="double"/> as [N] scale.
/// </summary>
[Quantity]
[QuantityUnit("Newton", "N", 1.0, None | Milli | Kilo | Mega)]
[QuantityOperation(typeof(QMass), typeof(QAcceleration), typeof(QForce))]
public readonly partial struct QForce : IQuantity<QForce>
{
}
