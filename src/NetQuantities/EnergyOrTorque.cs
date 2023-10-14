using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace NetQuantities
{
    /// <summary>
    /// Intermediate type for energy or torque.
    /// </summary>
    public readonly struct EnergyOrTorque
    {
        private readonly double _RawValue;

        internal EnergyOrTorque(double value) => _RawValue = value;

        /// <summary>
        /// Casts into <see cref="QEnergy"/>.
        /// </summary>
        /// <returns></returns>
        public QEnergy AsEnergy() => new(_RawValue);

        /// <summary>
        /// Casts into <see cref="QTorque"/>.
        /// </summary>
        /// <returns></returns>
        public QTorque AsTorque() => new(_RawValue);

        /// <summary>
        /// Casts into <see cref="QEnergy"/>.
        /// </summary>
        /// <param name="x"></param>
        public static implicit operator QEnergy(EnergyOrTorque x)
            => x.AsEnergy();

        /// <summary>
        /// Casts into <see cref="QTorque"/>.
        /// </summary>
        /// <param name="x"></param>
        public static implicit operator QTorque(EnergyOrTorque x)
            => x.AsTorque();
    }

    partial struct QLength
#if NET7_0_OR_GREATER
        : IMultiplyOperators<QLength, QForce, EnergyOrTorque>
#endif
    {
        /// <inheritdoc />
        public static EnergyOrTorque operator *(QLength x, QForce y)
            => new(x.RawValue * y.RawValue);
    }

    partial struct QForce
#if NET7_0_OR_GREATER
        : IMultiplyOperators<QForce, QLength, EnergyOrTorque>
#endif
    {
        /// <inheritdoc />
        public static EnergyOrTorque operator *(QForce x, QLength y)
            => new(x.RawValue * y.RawValue);
    }

    partial struct QEnergy
        : IQuantity<QEnergy>
#if NET7_0_OR_GREATER
    , IDivisionOperators<QEnergy, QForce, QLength>
    , IDivisionOperators<QEnergy, QLength, QForce>
#endif
    {
        /// <inheritdoc />
        public static QLength operator /(QEnergy x, QForce y)
            => new(x.RawValue * y.RawValue);

        /// <inheritdoc />
        public static QForce operator /(QEnergy x, QLength y)
            => new(x.RawValue * y.RawValue);
    }

    partial struct QTorque
    : IQuantity<QTorque>
#if NET7_0_OR_GREATER
    , IDivisionOperators<QTorque, QForce, QLength>
    , IDivisionOperators<QTorque, QLength, QForce>
#endif
    {
        /// <inheritdoc />
        public static QLength operator /(QTorque x, QForce y)
            => new(x.RawValue * y.RawValue);

        /// <inheritdoc />
        public static QForce operator /(QTorque x, QLength y)
            => new(x.RawValue * y.RawValue);
    }
}
