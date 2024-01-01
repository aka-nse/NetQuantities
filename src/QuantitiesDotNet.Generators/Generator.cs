using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuantitiesDotNet.Generators;

[Generator]
public class Generator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(callback: GenerateAttributes);

        var quantityAttributeSymbol = context
            .CompilationProvider
            .GetMetadata("QuantitiesDotNet.QuantityAttribute");
        var quantityUnitAttributeSymbol = context
            .CompilationProvider
            .GetMetadata("QuantitiesDotNet.QuantityUnitAttribute");
        var quantityOperationAttributeSymbol = context
            .CompilationProvider
            .GetMetadata("QuantitiesDotNet.QuantityOperationAttribute");
        var attributedFiles = context.SyntaxProvider
            .FindAttributedMembers<StructDeclarationSyntax, INamedTypeSymbol>(quantityAttributeSymbol);

        var source = attributedFiles
            .Combine(quantityAttributeSymbol
                .Combine(quantityUnitAttributeSymbol
                    .Combine(quantityOperationAttributeSymbol)));
        context.RegisterSourceOutput(source, GenerateUnitTypeImplements);
    }


    private void GenerateAttributes(IncrementalGeneratorPostInitializationContext context)
    {
        var canceller = context.CancellationToken;
        canceller.ThrowIfCancellationRequested();
        context.AddSource("Attributes.cs", new AttributesText().TransformText());
    }


    private void GenerateUnitTypeImplements(
        SourceProductionContext context,
        (AttributedMemberInfo<INamedTypeSymbol> info,
        (INamedTypeSymbol qAttr, (INamedTypeSymbol unitAttr, INamedTypeSymbol opAttr))) tpl)
    {
        var canceller = context.CancellationToken;
        canceller.ThrowIfCancellationRequested();

        var (info, (qAttr, (qUnitAttr, qOpAttr))) = tpl;
        var attributes = info.TargetSymbol.GetAttributes();
        var qDef = attributes
            .Single(attr => SymbolEqualityComparer.Default.Equals(attr.AttributeClass, qAttr));
        var unitDefs = attributes
            .Where(attr => SymbolEqualityComparer.Default.Equals(attr.AttributeClass, qUnitAttr));
        var operationDefs = attributes
            .Where(attr => SymbolEqualityComparer.Default.Equals(attr.AttributeClass, qOpAttr));

        var unitSource = new QuantityImplement()
        {
            TargetTypeName = info.TargetSymbol.Name,
            IsRefLikeType = info.TargetSymbol.IsRefLikeType,
            QuantityDef = QuantityDef.GetQuantityDef(qDef),
            UnitSymbols = unitDefs
                .SelectMany(UnitSymbolDef.GetUnitSymbols)
                .ToArray(),
            UnitOperations = operationDefs
                .Select(attr => new UnitOperationDef(attr))
                .ToArray(),
        };

        string sourceCode = unitSource.TransformText();
        context.AddSource(
            $"{info.TargetSymbol.Name}.g.cs",
            sourceCode);
    }
}
