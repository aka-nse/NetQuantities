using System;
using System.Numerics;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of torque.
/// This type can be re-interpret-casted into <see cref="double"/> as [N*m] scale.
/// </summary>
[Quantity]
[QuantityUnit("NewtonMetre", "N*m", 1.0)]
public readonly partial struct QTorque : IQuantity
{
}
