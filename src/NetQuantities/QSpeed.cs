﻿using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;


/// <summary>
/// Represents a value of velocity.
/// This type can be re-interpret-casted into <see cref="double"/> as [m/s] scale.
/// </summary>
[Quantity]
[QuantityUnit("MetrePerSecond", "m/s", 1.0, None | Milli | Micro | Nano | Kilo)]
[QuantityUnit("MetrePerMinute", "m/min", 1.0 / 60)]
[QuantityUnit("KilometrePerHour", "km/h", 1.0e+3 / 3600)]
[QuantityOperation(typeof(QTime), typeof(QSpeed), typeof(QLength))]
public readonly partial struct QSpeed : IQuantity
{
}
