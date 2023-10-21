using System;
using System.Numerics;

namespace NetQuantities
{
    public interface IQuantityValue<T>
        where T : notnull
    {
        public T RawValue { get; }
    }

    public partial interface IQuantity
        : IComparable
        , IFormattable
#if NET7_0_OR_GREATER
        , ISpanFormattable
#endif
    {
    }

    public partial interface IQuantity<TSelf>
        : IQuantity
        , IQuantityValue<double>
        , IComparable<TSelf>
        , IEquatable<TSelf>
#if NET6_0_OR_GREATER
        , ISpanFormattable
#endif
#if NET7_0_OR_GREATER
        , IComparisonOperators<TSelf, TSelf, bool>
        , IAdditionOperators<TSelf, TSelf, TSelf>
        , ISubtractionOperators<TSelf, TSelf, TSelf>
        , IMultiplyOperators<TSelf, double, TSelf>
        , IDivisionOperators<TSelf, double, TSelf>
        , IModulusOperators<TSelf, TSelf, TSelf>
        , IAdditiveIdentity<TSelf, TSelf>
        , IMultiplicativeIdentity<TSelf, double>
        , IUnaryPlusOperators<TSelf, TSelf>
        , IUnaryNegationOperators<TSelf, TSelf>
    #endif
        where TSelf : IQuantity<TSelf>
    {
    }
}

#if NET7_0_OR_GREATER
namespace NetQuantities.Generic
{
    public interface IQuantity<TSelf, T>
        : IQuantity
        , IQuantityValue<T>
        , IComparable<TSelf>
        , IEquatable<TSelf>
        , IComparisonOperators<TSelf, TSelf, bool>
        , IAdditionOperators<TSelf, TSelf, TSelf>
        , ISubtractionOperators<TSelf, TSelf, TSelf>
        , IMultiplyOperators<TSelf, T, TSelf>
        , IDivisionOperators<TSelf, T, TSelf>
        , IModulusOperators<TSelf, TSelf, TSelf>
        , IAdditiveIdentity<TSelf, TSelf>
        , IMultiplicativeIdentity<TSelf, T>
        , IUnaryPlusOperators<TSelf, TSelf>
        , IUnaryNegationOperators<TSelf, TSelf>
        where T : notnull, INumber<T>
        where TSelf : IQuantity<TSelf, T>
    {
    }
}
#endif