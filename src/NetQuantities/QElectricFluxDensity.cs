using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric flux density.
/// This type can be re-interpret-casted into <see cref="double"/> as [C/m^2] scale.
/// </summary>
[Quantity]
[QuantityUnit("CoulombPerSquareMetre", "C/m^2", 1.0)]
[QuantityOperation(typeof(QArea), typeof(QElectricFluxDensity), typeof(QElectricCharge))]
public readonly partial struct QElectricFluxDensity : IQuantity
{
}

