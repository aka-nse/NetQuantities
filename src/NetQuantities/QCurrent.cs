using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of electric current.
/// This type can be re-interpret-casted into <see cref="double"/> as [A] scale.
/// </summary>
[Quantity]
[QuantityUnit("Kiloampare", "kA", 1.0e+3)]
[QuantityUnit("Ampere", "A", 1.0)]
[QuantityUnit("Milliampere", "mA", 1.0e-3)]
[QuantityUnit("Microampare", "uA", 1.0e-6)]
public readonly partial struct QCurrent : IQuantity
{
}
