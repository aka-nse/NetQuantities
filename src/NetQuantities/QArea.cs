using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of area.
/// This type can be re-interpret-casted into <see cref="double"/> as [m^2] scale.
/// </summary>
[Quantity]
[QuantityUnit("Metre2", "m^2", 1.0)]
[QuantityUnit("Centimetre2", "cm^2", 1.0e-4)]
[QuantityUnit("Millimetre2", "mm^2", 1.0e-6)]
[QuantityUnit("Micrometre2", "um^2", 1.0e-12)]
[QuantityUnit("Nanometre2", "nm^2", 1.0e-18)]
[QuantityUnit("Kilometre2", "km^2", 1.0e+6)]
[QuantityUnit("Hectare", "ha", 1.0e+4)]
[QuantityOperation(typeof(QLength), typeof(QLength), typeof(QArea))]
public readonly partial struct QArea : IQuantity
{
}
