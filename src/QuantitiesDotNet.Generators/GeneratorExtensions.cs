using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace QuantitiesDotNet.Generators;

internal static class GeneratorExtensions
{
    public static IncrementalValueProvider<INamedTypeSymbol> GetMetadata(
        this IncrementalValueProvider<Compilation> provider,
        string metadataName)
        => provider.Select((compilation, canceller) =>
        {
            canceller.ThrowIfCancellationRequested();
            return compilation.GetTypeByMetadataName(metadataName)
                ?? throw new NullReferenceException();
        });


    public static IncrementalValuesProvider<AttributedMemberInfo<TSymbol>> FindAttributedMembers<TSyntax, TSymbol>(
        this SyntaxValueProvider provider,
        IncrementalValueProvider<INamedTypeSymbol> attributeSymbol)
        where TSyntax : MemberDeclarationSyntax
        where TSymbol : class, ISymbol
    {
        static bool predicate(SyntaxNode node, CancellationToken canceller)
        {
            canceller.ThrowIfCancellationRequested();
            return node is TSyntax { AttributeLists.Count: > 0 };
        }

        static TSymbol? transform(GeneratorSyntaxContext context, CancellationToken canceller)
        {
            canceller.ThrowIfCancellationRequested();
            var syntax = (context.Node as TSyntax)!;
#pragma warning disable RS1039 // 'SemanticModel.GetDeclaredSymbol()' will always return 'null' for this call.
            return context.SemanticModel.GetDeclaredSymbol(syntax, canceller) as TSymbol;
#pragma warning restore RS1039 // 'SemanticModel.GetDeclaredSymbol()' will always return 'null' for this call.
        }

        static AttributedMemberInfo<TSymbol>? postTransform(
            (TSymbol? target, INamedTypeSymbol interestedAttribute) tuple,
            CancellationToken canceller)
        {
            var (target, interestedAttribute) = tuple;
            if (target is null)
            {
                return null;
            }
            foreach (var attachedAttribute in target.GetAttributes())
            {
                if (SymbolEqualityComparer.Default.Equals(attachedAttribute.AttributeClass, interestedAttribute))
                {
                    return new(target, interestedAttribute);
                }
            }
            return null;
        }

        return provider
            .CreateSyntaxProvider(predicate, transform)
            .Combine(attributeSymbol)
            .Select(postTransform)
            .Where(info => info is not null)!;
    }

}