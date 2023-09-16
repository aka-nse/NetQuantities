using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of frequency.
/// This type can be re-interpret-casted into <see cref="double"/> as [Hz] scale.
/// </summary>
[Quantity]
[QuantityUnit("Hertz", "Hz", 1.0)]
[QuantityOperation(typeof(QTime), typeof(QFrequency), typeof(QDimensionless))]
public readonly partial struct QFrequency : IQuantity
{
}
