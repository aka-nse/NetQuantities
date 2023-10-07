using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of amount of substance.
/// This type can be re-interpret-casted into <see cref="double"/> as [mol] scale.
/// </summary>
[Quantity]
[QuantityUnit("Mole", "mol", 1.0, None | Milli | Kilo)]
public readonly partial struct QSubstanceAmount : IQuantity
{
}
