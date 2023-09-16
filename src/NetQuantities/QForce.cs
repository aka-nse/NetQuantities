﻿using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of mechanical force.
/// This type can be re-interpret-casted into <see cref="double"/> as [N] scale.
/// </summary>
[Quantity]
[QuantityUnit("Newton", "N", 1.0)]
[QuantityOperation(typeof(QMass), typeof(QAcceleration), typeof(QForce))]
public readonly partial struct QForce : IQuantity
{
}
