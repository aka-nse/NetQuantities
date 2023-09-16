using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of length.
/// This type can be re-interpret-casted into <see cref="double"/> as [m] scale.
/// </summary>
[Quantity]
[QuantityUnit("Metre", "m", 1.0)]
[QuantityUnit("Centimetre", "cm", 1.0e-2)]
[QuantityUnit("Millimetre", "mm", 1.0e-3)]
[QuantityUnit("Micrometre", "um", 1.0e-6)]
[QuantityUnit("Nanometre", "nm", 1.0e-9)]
[QuantityUnit("Kilometre", "km", 1.0e+3)]
public readonly partial struct QLength : IQuantity
{
}
