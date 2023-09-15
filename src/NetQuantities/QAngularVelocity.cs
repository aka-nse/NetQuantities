using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of angular velocity.
/// This type can be re-interpret-casted into <see cref="double"/> as [rad/s] scale.
/// </summary>
[Quantity]
[QuantityUnit("RadianPerSecond", "rad/s", 1.0)]
[QuantityUnit("DegreePerSecond", "deg/s", 2 * Math.PI / 360)]
[QuantityUnit("MilliDegreePerSecond", "mdeg/s", 2 * Math.PI / 360e+3)]
[QuantityOperation(typeof(QTime), typeof(QAngularVelocity), typeof(QAngle))]
public readonly partial struct QAngularVelocity : IQuantity
{
}
