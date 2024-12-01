using System.Text;

namespace QuantitiesDotNet.Generators;

partial class Generator
{
}

internal class QuantityImplementBuilder(
    string targetTypeName,
    bool isRefLikeType,
    QuantityDef QuantityDef,
    IList<UnitSymbolDef> UnitSymbols,
    IList<UnitOperationDef> UnitOperations
    )
{
    public void GenerateTargetTypeInterfaces(StringBuilder sb, bool isGeneric)
    {
        if (isRefLikeType)
        {
            return;
        }
        var valueType = isGeneric ? "T" : "double";
        var targetType = isGeneric ? $"{targetTypeName}<T>" : targetTypeName;

        sb.AppendLine($"""
    : IQuantity<{targetType}{(isGeneric ? ", T" : "")}>
    , IComparable<{targetType}>
    , IEquatable<{targetType}>
""");
        if(isGeneric)
        {
            sb.AppendLine("#if NET7_0_OR_GREATER");
        }
        sb.AppendLine($"""
    , IComparisonOperators<{targetType}, {targetType}, bool>
    , IAdditionOperators<{targetType}, {targetType}, {targetType}>
    , ISubtractionOperators<{targetType}, {targetType}, {targetType}>
    , IMultiplyOperators<{targetType}, {valueType}, {targetType}>
    , IDivisionOperators<{targetType}, {valueType}, {targetType}>
    , IDivisionOperators<{targetType}, {targetType}, {valueType}>
    , IModulusOperators<{targetType}, {targetType}, {targetType}>
    , IAdditiveIdentity<{targetType}, {targetType}>
    , IMultiplicativeIdentity<{targetType}, {valueType}>
    , IUnaryPlusOperators<{targetType}, {targetType}>
    , IUnaryNegationOperators<{targetType}, {targetType}>
""");
        if (isGeneric)
        {
            sb.AppendLine("#endif");
        }
        return;
    }
}