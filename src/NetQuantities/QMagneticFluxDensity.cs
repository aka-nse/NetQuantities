﻿using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of magnetic flux density.
/// This type can be re-interpret-casted into <see cref="double"/> as [T] scale.
/// </summary>
[Quantity]
[QuantityUnit("Tesla", "T", 1.0, None | Milli | Micro)]
[QuantityOperation(typeof(QArea), typeof(QMagneticFluxDensity), typeof(QMagneticFlux))]
public readonly partial struct QMagneticFluxDensity : IQuantity<QMagneticFluxDensity>
{
}