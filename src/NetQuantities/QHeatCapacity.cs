using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of heat capacity.
/// This type can be re-interpret-casted into <see cref="double"/> as [J/K] scale.
/// </summary>
[Quantity]
[QuantityUnit("JoulePerKelvin", "J/K", 1.0)]
[QuantityOperation(typeof(QTemperature), typeof(QHeatCapacity), typeof(QEnergy))]
public readonly partial struct QHeatCapacity : IQuantity
{
}
