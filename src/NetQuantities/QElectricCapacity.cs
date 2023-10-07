using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric capacity.
/// This type can be re-interpret-casted into <see cref="double"/> as [F] scale.
/// </summary>
[Quantity]
[QuantityUnit("Farad", "F", 1.0)]
[QuantityUnit("Millifarad", "mF", 1.0e-3)]
[QuantityUnit("Microfarad", "uF", 1.0e-6)]
[QuantityUnit("Nanofarad", "nF", 1.0e-9)]
[QuantityUnit("Picofarad", "pF", 1.0e-12)]
[QuantityOperation(typeof(QElectricCapacity), typeof(QElectricVoltage), typeof(QElectricCharge))]
public readonly partial struct QElectricCapacity : IQuantity
{
}
