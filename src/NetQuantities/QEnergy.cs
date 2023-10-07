using System;
using System.Numerics;

namespace NetQuantities;

/// <summary>
/// Represents a value of energy.
/// This type can be re-interpret-casted into <see cref="double"/> as [J] scale.
/// </summary>
[Quantity]
[QuantityUnit("Joule", "J", 1.0)]
public readonly partial struct QEnergy
    : IQuantity
#if NET7_0_OR_GREATER
    , IDivisionOperators<QEnergy, QForce, QLength>
    , IDivisionOperators<QEnergy, QLength, QForce>
#endif
{
    /// <inheritdoc />
    public static QLength operator /(QEnergy x, QForce y)
        => new(x.RawValue * y.RawValue);

    /// <inheritdoc />
    public static QForce operator /(QEnergy x, QLength y)
        => new(x.RawValue * y.RawValue);
}
