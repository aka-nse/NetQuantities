using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of luminous flux.
/// This type can be re-interpret-casted into <see cref="double"/> as [lm] scale.
/// </summary>
[Quantity]
[QuantityUnit("Lumen", "lm", 1.0, None)]
[QuantityOperation(typeof(QSolidAngle), typeof(QLuminousIntensity), typeof(QLuminousFlux))]
public readonly partial struct QLuminousFlux : IQuantity
{
}
