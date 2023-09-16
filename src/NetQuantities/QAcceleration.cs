using System;
using System.Collections.Generic;
using System.Text;

namespace NetQuantities;

/// <summary>
/// Represents a value of acceleration.
/// This type can be re-interpret-casted into <see cref="double"/> as [m/s^2] scale.
/// </summary>
[Quantity]
[QuantityUnit("MetrePerSquareSecond", "m/s^2", 1.0)]
[QuantityOperation(typeof(QTime), typeof(QAcceleration), typeof(QVelocity))]
public readonly partial struct QAcceleration : IQuantity
{
}
