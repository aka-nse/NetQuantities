using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of volume.
/// This type can be re-interpret-casted into <see cref="double"/> as [m^3] scale.
/// </summary>
[Quantity]
[QuantityUnit("CubicMetre", "m^3", 1.0, None | Centi, 3)]
[QuantityUnit("Litre", "L", 1e-3, None, 3)]
[QuantityOperation(typeof(QLength), typeof(QArea), typeof(QVolume))]
public readonly partial struct QVolume : IQuantity<QVolume>
{
}
