using System;
using System.Numerics;
namespace NetQuantities;

/// <summary>
/// Represents a value of torque.
/// This type can be re-interpret-casted into <see cref="double"/> as [N*m] scale.
/// </summary>
[Quantity]
[QuantityUnit("NewtonMetre", "N*m", 1.0)]
public readonly partial struct QTorque
    : IQuantity
#if NET7_0_OR_GREATER
    , IDivisionOperators<QTorque, QForce, QLength>
    , IDivisionOperators<QTorque, QLength, QForce>
#endif
{
    /// <inheritdoc />
    public static QLength operator /(QTorque x, QForce y)
        => new(x.RawValue * y.RawValue);

    /// <inheritdoc />
    public static QForce operator /(QTorque x, QLength y)
        => new(x.RawValue * y.RawValue);
}
