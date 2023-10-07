using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of pressure.
/// This type can be re-interpret-casted into <see cref="double"/> as [Pa] scale.
/// </summary>
[Quantity]
[QuantityUnit("Pascal", "Pa", 1.0, None | Milli | Micro | Nano | Hecto | Kilo | Mega | Giga)]
[QuantityOperation(typeof(QArea), typeof(QPressure), typeof(QForce))]
public readonly partial struct QPressure : IQuantity
{
}
