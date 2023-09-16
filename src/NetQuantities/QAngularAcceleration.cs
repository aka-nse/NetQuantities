using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of angular acceleration.
/// This type can be re-interpret-casted into <see cref="double"/> as [rad/s^2] scale.
/// </summary>
[Quantity]
[QuantityUnit("RadianPerSquareSecond", "rad/s^2", 1.0)]
[QuantityOperation(typeof(QTime), typeof(QAngularAcceleration), typeof(QAngularVelocity))]
public readonly partial struct QAngularAcceleration : IQuantity
{
}
