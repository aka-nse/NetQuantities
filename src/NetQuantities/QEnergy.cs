using System;
using static NetQuantities.UnitPrefix;

using System.Numerics;

namespace NetQuantities;

/// <summary>
/// Represents a value of energy.
/// This type can be re-interpret-casted into <see cref="double"/> as [J] scale.
/// </summary>
[Quantity]
[QuantityUnit("Joule", "J", 1.0, None | Milli | Kilo | Mega | Giga)]
[QuantityUnit("ElectronVolt", "eV", 1.602176634e-19, None | Milli | Kilo | Mega | Giga)]
public readonly partial struct QEnergy : IQuantity
{
}
