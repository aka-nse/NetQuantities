using System;
using System.Collections.Generic;
using System.Text;

namespace QuantitiesDotNet;

/// <summary>
/// Calculation halfway type that represents [L^1 * M^1] dimension.
/// This type is intended to be used only during conversion to other types.
/// </summary>
[Quantity(L: 1, M: 1, T: 0, I: 0, Th: 0, N: 0, J: 0)]
[QuantityOperation(typeof(QLength), typeof(QMass), typeof(QHalfway_L1_M1_T0_I0_Th0_N0_J0))]
[QuantityOperation(typeof(QMomentum), typeof(QTime), typeof(QHalfway_L1_M1_T0_I0_Th0_N0_J0))]
public readonly partial struct QHalfway_L1_M1_T0_I0_Th0_N0_J0 : IQuantity<QHalfway_L1_M1_T0_I0_Th0_N0_J0>
{
}

/// <summary>
/// Calculation halfway type that represents [T^-2] dimension.
/// This type is intended to be used only during conversion to other types.
/// </summary>
[Quantity(L: 0, M: 0, T: -2, I: 0, Th: 0, N: 0, J: 0)]
[QuantityOperation(typeof(QHalfway_L0_M0_Tm2_I0_Th0_N0_J0), typeof(QTime), typeof(QFrequency))]
[QuantityOperation(typeof(QHalfway_L0_M0_Tm2_I0_Th0_N0_J0), typeof(QLength), typeof(QAcceleration))]
[QuantityOperation(typeof(QHalfway_L1_M1_T0_I0_Th0_N0_J0), typeof(QHalfway_L0_M0_Tm2_I0_Th0_N0_J0), typeof(QForce))]
public readonly partial struct QHalfway_L0_M0_Tm2_I0_Th0_N0_J0 : IQuantity<QHalfway_L0_M0_Tm2_I0_Th0_N0_J0>
{
}
