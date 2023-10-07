using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of catalytic activity.
/// This type can be re-interpret-casted into <see cref="double"/> as [kat] scale.
/// </summary>
[Quantity]
[QuantityUnit("Katal", "kat", 1.0)]
[QuantityUnit("Millikatal", "mkat", 1.0e-3)]
[QuantityUnit("Microkatal", "ukat", 1.0e-6)]
[QuantityUnit("Nanokatal", "nkat", 1.0e-9)]
[QuantityUnit("Unit", "unit", 1e-6 / 60)]
[QuantityUnit("Milliunit", "munit", 1e-9 / 60)]
[QuantityOperation(typeof(QTime), typeof(QCatalyticActivity), typeof(QSubstanceAmount))]
public readonly partial struct QCatalyticActivity : IQuantity
{
}
