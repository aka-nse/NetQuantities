﻿using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of voltage.
/// This type can be re-interpret-casted into <see cref="double"/> as [V] scale.
/// </summary>
[Quantity]
[QuantityUnit("Volt", "V", 1.0)]
public readonly partial struct QElectricVoltage : IQuantity
{
}
