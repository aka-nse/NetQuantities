using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of angular acceleration.
/// This type can be re-interpret-casted into <see cref="double"/> as [rad/s^2] scale.
/// </summary>
[Quantity]
[QuantityUnit("RadianPerSquareSecond", "rad/s^2", 1.0)]
[QuantityUnit("DegreePerSquareSecond", "deg/s^2", 2 * Math.PI / 360, None | Milli)]
[QuantityOperation(typeof(QTime), typeof(QAngularAcceleration), typeof(QAngularVelocity))]
public readonly partial struct QAngularAcceleration : IQuantity<QAngularAcceleration>
{
}
