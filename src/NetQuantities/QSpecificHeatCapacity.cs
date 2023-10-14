using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of specific heat capacity.
/// This type can be re-interpret-casted into <see cref="double"/> as [J/(Kg*K)] scale.
/// </summary>
[Quantity]
[QuantityUnit("JoulePerKilogramPerKelvin", "J/(Kg*K)", 1.0, None | Kilo)]
[QuantityOperation(typeof(QMass), typeof(QSpecificHeatCapacity), typeof(QHeatCapacity))]
public readonly partial struct QSpecificHeatCapacity : IQuantity<QSpecificHeatCapacity>
{
}

