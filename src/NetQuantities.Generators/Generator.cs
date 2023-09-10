using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NetQuantities.Generators;

[Generator]
public class Generator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(callback: GenerateAttributes);

        var quantityAttributeSymbol = context
            .CompilationProvider
            .GetMetadata("NetQuantities.QuantityAttribute");
        var quantityUnitAttributeSymbol = context
            .CompilationProvider
            .GetMetadata("NetQuantities.QuantityUnitAttribute");
        var quantityOperationAttributeSymbol = context
            .CompilationProvider
            .GetMetadata("NetQuantities.QuantityOperationAttribute");
        var attributedFiles = context.SyntaxProvider
            .FindAttributedMembers<StructDeclarationSyntax, INamedTypeSymbol>(quantityAttributeSymbol);

        var source = attributedFiles
            .Combine(quantityUnitAttributeSymbol
                .Combine(quantityOperationAttributeSymbol));
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
        (INamedTypeSymbol unitAttr, INamedTypeSymbol opAttr)) tpl)
    {
        var canceller = context.CancellationToken;
        canceller.ThrowIfCancellationRequested();

        var (info, (qUnitAttr, qOpAttr)) = tpl;
        var attributes = info.TargetSymbol.GetAttributes();
        var unitDefs = attributes
            .Where(attr => SymbolEqualityComparer.Default.Equals(attr.AttributeClass, qUnitAttr));
        var operationDefs = attributes
            .Where(attr => SymbolEqualityComparer.Default.Equals(attr.AttributeClass, qOpAttr));

        var unitSource = new QuantityImplement()
        {
            TargetTypeName = info.TargetSymbol.Name,
            UnitSymbols = unitDefs
                .Select(attr => new UnitSymbolDef(attr))
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
