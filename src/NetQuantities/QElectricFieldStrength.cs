using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of thermodynamic electric field strength.
/// This type can be re-interpret-casted into <see cref="double"/> as [V/m] scale.
/// </summary>
[Quantity]
[QuantityUnit("VoltPerMetre", "V/m", 1.0)]
[QuantityOperation(typeof(QLength), typeof(QElectricFieldStrength), typeof(QElectricVoltage))]
public readonly partial struct QElectricFieldStrength : IQuantity
{
}
