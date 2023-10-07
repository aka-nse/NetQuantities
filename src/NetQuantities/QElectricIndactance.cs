using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of electric indactance.
/// This type can be re-interpret-casted into <see cref="double"/> as [H] scale.
/// </summary>
[Quantity]
[QuantityUnit("Henry", "H", 1.0)]
public readonly partial struct QElectricIndactance : IQuantity
{
}
