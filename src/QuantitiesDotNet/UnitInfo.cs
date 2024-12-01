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
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace QuantitiesDotNet.Generic
#pragma warning restore IDE0130 // Namespace does not match folder structure
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