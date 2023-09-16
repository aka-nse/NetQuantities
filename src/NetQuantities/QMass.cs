using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of mass.
/// This type can be re-interpret-casted into <see cref="double"/> as [kg] scale.
/// </summary>
[Quantity]
[QuantityUnit("Kilogram", "kg", 1.0)]
[QuantityUnit("Gram", "g", 1.0e-3)]
[QuantityUnit("Milligram", "mg", 1.0e-6)]
[QuantityUnit("Microgram", "ug", 1.0e-9)]
[QuantityUnit("Tonne", "t", 1.0e+3)]
public readonly partial struct QMass : IQuantity
{
}
