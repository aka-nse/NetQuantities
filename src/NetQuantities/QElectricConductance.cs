using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric conductance.
/// This type can be re-interpret-casted into <see cref="double"/> as [S] scale.
/// </summary>
[Quantity]
[QuantityUnit("Siemens", "S", 1.0)]
[QuantityUnit("Millisiemens", "mS", 1.0e-3)]
[QuantityUnit("Microsiemens", "uS", 1.0e-6)]
[QuantityUnit("Nanosiemens", "nS", 1.0e-9)]
[QuantityOperation(typeof(QElectricResistance), typeof(QElectricConductance), typeof(QDimensionless))]
public readonly partial struct QElectricConductance : IQuantity
{
}
