using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of mass flow rate.
/// This type can be re-interpret-casted into <see cref="double"/> as [kg/s] scale.
/// </summary>
[Quantity]
[QuantityUnit("GramPerSecond", "g/s", 1e-3, None | Milli | Kilo)]
[QuantityOperation(typeof(QMassFlowRate), typeof(QTime), typeof(QMass))]
public readonly partial struct QMassFlowRate : IQuantity<QMassFlowRate>
{
}
