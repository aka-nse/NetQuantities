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
    private static readonly IReadOnlyList<(int flag, string name, string symbol, double scale)> _UnitPrefix
        = new[]
        {
            (0b_0000_0001, "Centi", "c", 1e-2),
            (0b_0000_0010, "Milli", "m", 1e-3),
            (0b_0000_0100, "Micro", "u", 1e-6),
            (0b_0000_1000, "Nano", "n", 1e-9),
            (0b_0001_0000, "Pico", "p", 1e-12),

            (0b_0000_0001 << 16, "Hecto", "h", 1e+2),
            (0b_0000_0010 << 16, "Kilo", "k", 1e+3),
            (0b_0000_0100 << 16, "Mega", "M", 1e+6),
            (0b_0000_1000 << 16, "Giga", "G", 1e+9),
            (0b_0001_0000 << 16, "Tera", "T", 1e+12),
        };

    public static IEnumerable<UnitSymbolDef> GetUnitSymbols(AttributeData attr)
    {
        var majorName = GetMajorName(attr);
        var shortName = GetShortName(attr);
        var scale = GetScale(attr);
        yield return new(majorName, shortName, scale);

        var prefix = attr.ConstructorArguments[3].Value is int flag ? flag : 0;
        var prefixSet = _UnitPrefix.Where(tpl => (tpl.flag & prefix) != 0);
        var camelMajorName = char.ToLower(majorName[0]) + majorName.Substring(1);
        foreach(var (_, name, symbol, pScale) in prefixSet)
        {
            var exMajorName = name + camelMajorName;
            var exShortName = symbol + shortName;
            yield return new(exMajorName, exShortName, scale * pScale);
        }
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