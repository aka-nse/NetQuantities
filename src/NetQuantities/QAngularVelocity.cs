﻿using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of angular velocity.
/// This type can be re-interpret-casted into <see cref="double"/> as [rad/s] scale.
/// </summary>
[Quantity]
[QuantityUnit("RadianPerSecond", "rad/s", 1.0)]
[QuantityUnit("DegreePerSecond", "deg/s", 2 * Math.PI / 360, None | Milli)]
[QuantityUnit("RevolutionPerMinute", "rpm", 2 * Math.PI / 60)]
[QuantityOperation(typeof(QTime), typeof(QAngularVelocity), typeof(QAngle))]
public readonly partial struct QAngularVelocity : IQuantity<QAngularVelocity>
{
}
