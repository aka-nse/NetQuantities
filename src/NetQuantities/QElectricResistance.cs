using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of electric resistance.
/// This type can be re-interpret-casted into <see cref="double"/> as [Ω] scale.
/// </summary>
[Quantity]
[QuantityUnit("Ohm", "Ω", 1.0)]
[QuantityUnit("Milliohm", "mΩ", 1.0e-3)]
[QuantityUnit("Microohm", "uΩ", 1.0e-6)]
[QuantityUnit("Kiloohm", "mΩ", 1.0e+3)]
[QuantityUnit("Megaohm", "mΩ", 1.0e+3)]
[QuantityOperation(typeof(QElectricCurrent), typeof(QElectricResistance), typeof(QElectricVoltage))]
public readonly partial struct QElectricResistance : IQuantity
{
}
