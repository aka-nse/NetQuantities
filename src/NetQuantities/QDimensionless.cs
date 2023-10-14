using System;

namespace NetQuantities
{
    /// <summary>
    /// Represents a value of dimensionless.
    /// This type can be re-interpret-casted into <see cref="double"/> as [1] scale.
    /// </summary>
    [Quantity]
    public readonly partial struct QDimensionless : IQuantity<QDimensionless>
    {
        public static QDimensionless FromRaw(double rawValue) => new(rawValue);

        public static implicit operator double(QDimensionless self) => self.RawValue;

        public static implicit operator QDimensionless(double value) => new QDimensionless(value);
    }
}


#if NET7_0_OR_GREATER

namespace NetQuantities.Generic
{
    /// <summary>
    /// Represents a value of dimensionless.
    /// This type can be re-interpret-casted into <typeparamref name="T"/> as [1] scale.
    /// </summary>
    public readonly partial struct QDimensionless<T> : IQuantity<QDimensionless<T>, T>
    {
        public static QDimensionless<T> FromRaw(T rawValue) => new(rawValue);

        public static implicit operator T(QDimensionless<T> self) => self.RawValue;

        public static implicit operator QDimensionless<T>(T value) => new QDimensionless<T>(value);
    }
}

#endif