﻿// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY T4. DO NOT CHANGE IT. CHANGE THE .tt FILE INSTEAD.
// </auto-generated>
using System;
using System.Collections.Generic;
using System.Text;

namespace NetQuantities;


/// <summary>
/// Calculation halfway type that represents [L^-2] dimension.
/// This type is intended to be used only during conversion to other types,
/// therefore it is defined as ref struct type.
/// </summary>
[Quantity(L: -2, M: 0, T: 0, I: 0, Th: 0, N: 0, J: 0)]
[QuantityOperation(typeof(QHalfway_Lm2_M0_T0_I0_Th0_N0_J0), typeof(QLength), typeof(QSpatialFrequency))]
public readonly ref partial struct QHalfway_Lm2_M0_T0_I0_Th0_N0_J0
{
}


/// <summary>
/// Calculation halfway type that represents [M^-1] dimension.
/// This type is intended to be used only during conversion to other types,
/// therefore it is defined as ref struct type.
/// </summary>
[Quantity(L: 0, M: -1, T: 0, I: 0, Th: 0, N: 0, J: 0)]
[QuantityOperation(typeof(QHalfway_L0_Mm1_T0_I0_Th0_N0_J0), typeof(QMass), typeof(QDimensionless))]
public readonly ref partial struct QHalfway_L0_Mm1_T0_I0_Th0_N0_J0
{
}


/// <summary>
/// Calculation halfway type that represents [L^1 * M^1] dimension.
/// This type is intended to be used only during conversion to other types,
/// therefore it is defined as ref struct type.
/// </summary>
[Quantity(L: 1, M: 1, T: 0, I: 0, Th: 0, N: 0, J: 0)]
[QuantityOperation(typeof(QLength), typeof(QMass), typeof(QHalfway_L1_M1_T0_I0_Th0_N0_J0))]
[QuantityOperation(typeof(QMomentum), typeof(QTime), typeof(QHalfway_L1_M1_T0_I0_Th0_N0_J0))]
public readonly ref partial struct QHalfway_L1_M1_T0_I0_Th0_N0_J0
{
}


