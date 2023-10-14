using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of solid angle.
/// This type can be re-interpret-casted into <see cref="double"/> as [sr] scale.
/// </summary>
[Quantity]
[QuantityUnit("Steradian", "sr", 1.0)]
[QuantityUnit("SquareDegree", "deg2", (2 * Math.PI / 360) * (2 * Math.PI / 360))]
public readonly partial struct QSolidAngle : IQuantity<QSolidAngle>
{
    public static readonly QSolidAngle WholeSphere = FromSteradian(4 * Math.PI);
}
