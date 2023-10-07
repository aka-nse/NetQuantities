﻿using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of angle.
/// This type can be re-interpret-casted into <see cref="double"/> as [rad] scale.
/// </summary>
[Quantity]
[QuantityUnit("Radian", "rad", 1.0)]
[QuantityUnit("Degree", "deg", 2 * Math.PI / 360, None | Milli)]
public readonly partial struct QAngle : IQuantity
{
}
