﻿using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of magnetic field strength.
/// This type can be re-interpret-casted into <see cref="double"/> as [A/m] scale.
/// </summary>
[Quantity]
[QuantityUnit("AmparePerMetre", "A/m", 1.0)]
public readonly partial struct QMagneticFieldStrength : IQuantity
{
}
