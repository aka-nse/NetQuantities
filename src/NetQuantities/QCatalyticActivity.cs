using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of catalytic activity.
/// This type can be re-interpret-casted into <see cref="double"/> as [kat] scale.
/// </summary>
[Quantity]
[QuantityUnit("Katal", "kat", 1.0, None | Milli | Micro | Nano)]
[QuantityUnit("Unit", "unit", 1e-6 / 60, None | Milli)]
[QuantityOperation(typeof(QTime), typeof(QCatalyticActivity), typeof(QSubstanceAmount))]
public readonly partial struct QCatalyticActivity : IQuantity<QCatalyticActivity>
{
}
