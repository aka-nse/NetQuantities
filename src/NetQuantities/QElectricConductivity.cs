using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of electric conductivity.
/// This type can be re-interpret-casted into <see cref="double"/> as [S/m] scale.
/// </summary>
[Quantity]
[QuantityUnit("SiemensPerMetre", "S/m", 1.0)]
[QuantityOperation(typeof(QLength), typeof(QElectricConductivity), typeof(QElectricConductance))]
public readonly partial struct QElectricConductivity : IQuantity
{
}
