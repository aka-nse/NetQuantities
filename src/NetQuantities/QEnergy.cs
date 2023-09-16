using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of energy.
/// This type can be re-interpret-casted into <see cref="double"/> as [J] scale.
/// </summary>
[Quantity]
[QuantityUnit("Joule", "J", 1.0)]
[QuantityOperation(typeof(QLength), typeof(QForce), typeof(QEnergy))]
public readonly partial struct QEnergy : IQuantity
{
}
