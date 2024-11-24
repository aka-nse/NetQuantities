using Microsoft.CodeAnalysis;

namespace QuantitiesDotNet.Generators;

internal record AttributedMemberInfo<TSymbol>
    where TSymbol : ISymbol
{
    public TSymbol TargetSymbol { get; }
    public INamedTypeSymbol AttributeSymbol { get; }

    public AttributedMemberInfo(TSymbol target, INamedTypeSymbol attribute)
    {
        TargetSymbol = target;
        AttributeSymbol = attribute;
    }
}