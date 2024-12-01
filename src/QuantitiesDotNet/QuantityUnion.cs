namespace QuantitiesDotNet
{
    /// <summary>
    /// Helpers of <see cref="QuantityUnion{T1, T2}"/>.
    /// </summary>
    public static partial class QuantityUnion
    {
    }

    /// <summary>
    /// Calculation halfway type.
    /// This type is intended to be used only during conversion to other types.
    /// </summary>
    public readonly struct QuantityUnion<T1, T2>
        where T1 : IQuantity<T1>
        where T2 : IQuantity<T2>
    {
        public readonly double RawValue;

        internal QuantityUnion(double value) => RawValue = value;
    }
}

#if NET7_0_OR_GREATER
namespace QuantitiesDotNet.Generic
{
    /// <summary>
    /// Helpers of <see cref="QuantityUnion{T1, T2}"/>.
    /// </summary>
    public static partial class QuantityUnion
    {
    }

    /// <summary>
    /// Calculation halfway type.
    /// This type is intended to be used only during conversion to other types.
    /// </summary>
    public readonly struct QuantityUnion<TValue, T1, T2>
        where TValue : INumber<TValue>
        where T1 : IQuantity<T1, TValue>
        where T2 : IQuantity<T2, TValue>
    {
        public readonly TValue RawValue;

        internal QuantityUnion(TValue value) => RawValue = value;
    }
}
#endif