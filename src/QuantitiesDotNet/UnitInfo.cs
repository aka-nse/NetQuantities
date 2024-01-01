using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace QuantitiesDotNet
{
    public record UnitInfo(
        double Scale,
        string MajorName,
        string UnitSymbol)
    {
    }
}

#if NET7_0_OR_GREATER
namespace QuantitiesDotNet.Generic
{
    public record UnitInfo<T>(
        T Scale,
        string MajorName,
        string UnitSymbol)
        where T : INumber<T>
    {
    }
}
#endif
