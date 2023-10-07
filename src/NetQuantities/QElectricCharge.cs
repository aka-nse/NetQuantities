using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric charge.
/// This type can be re-interpret-casted into <see cref="double"/> as [C] scale.
/// </summary>
[Quantity]
[QuantityUnit("Coulomb", "C", 1.0)]
[QuantityUnit("Millicoulomb", "mC", 1.0e-3)]
[QuantityUnit("Microcoulomb", "uC", 1.0e-6)]
[QuantityUnit("Nanocoulomb", "nC", 1.0e-9)]
[QuantityUnit("Picocoulomb", "pC", 1.0e-12)]
[QuantityUnit("AmpareHour", "Ah", 3600)]
[QuantityUnit("Milliamparehour", "mAh", 3.6)]
[QuantityUnit("Kiloamparehour", "kAh", 3600 * 1e+3)]
[QuantityOperation(typeof(QElectricCurrent), typeof(QTime), typeof(QElectricCharge))]
public readonly partial struct QElectricCharge : IQuantity
{
}
