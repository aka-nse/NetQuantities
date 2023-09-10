using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetQuantities.Generators;


partial class QuantityImplement
{
    public string TargetTypeName { get; init; } = null!;
    public IList<UnitSymbolDef> UnitSymbols { get; init; } = new List<UnitSymbolDef>();
    public IList<UnitOperationDef> UnitOperations { get; init; } = new List<UnitOperationDef>();
}


public record UnitSymbolDef(
    string MajorName,
    string ShortName,
    double Scale)
{
    public UnitSymbolDef(AttributeData attr)
        : this(
              GetMajorName(attr),
              GetShortName(attr),
              GetScale(attr))
    {
    }

    private static string GetMajorName(AttributeData attr)
        => attr
        .ConstructorArguments[0]
        .Value
        as string
        ?? throw new InvalidOperationException();

    private static string GetShortName(AttributeData attr)
        => attr
        .ConstructorArguments[1]
        .Value
        as string
        ?? throw new InvalidOperationException();

    private static double GetScale(AttributeData attr)
        => attr
        .ConstructorArguments[2]
        .Value
        is double x
        ? x
        : throw new InvalidOperationException();
}


public record UnitOperationDef(
    string MultiplicantType,
    string MultiplierType,
    string ProductType)
{
    public UnitOperationDef(AttributeData attr)
        : this(
              GetMultiplicantType(attr),
              GetMultiplierType(attr),
              GetProductType(attr))
    {
    }

    private static string GetMultiplicantType(AttributeData attr)
        => (attr.ConstructorArguments[0].Value as INamedTypeSymbol)
            ?.Name
            ?? throw new InvalidOperationException();

    private static string GetMultiplierType(AttributeData attr)
        => (attr.ConstructorArguments[1].Value as INamedTypeSymbol)
            ?.Name
            ?? throw new InvalidOperationException();

    private static string GetProductType(AttributeData attr)
        => (attr.ConstructorArguments[2].Value as INamedTypeSymbol)
            ?.Name
            ?? throw new InvalidOperationException();
}