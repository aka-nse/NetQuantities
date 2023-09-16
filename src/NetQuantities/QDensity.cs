﻿using System;
namespace NetQuantities;


/// <summary>
/// Represents a value of density.
/// This type can be re-interpret-casted into <see cref="double"/> as [kg/m^3] scale.
/// </summary>
[Quantity]
[QuantityUnit("KilogramPerCubicMetre", "kg/m^3", 1.0)]
[QuantityOperation(typeof(QVolume), typeof(QDensity), typeof(QMass))]
public readonly partial struct QDensity : IQuantity
{
}
