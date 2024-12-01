using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace QuantitiesDotNet;

internal partial record QuantityParseInfo(
    string Number,
    string UnitSelector)
{
    // lang=regex
    private const string _FormatMatcherPattern = @"(?<number>[\+\-]?\d*(?:[\.\,]\d*)?(?:[Ee][\+\-]\d+)?) *(?:(?:\[(?<unit>[\w/^*() ]+)\])|(?<unit>[\w/^*() ]+))";
    private static readonly Regex _FormatMatcher
#if NET7_0_OR_GREATER
        = GenerateFormatMatcher();
    [GeneratedRegex(_FormatMatcherPattern)]
    private static partial Regex GenerateFormatMatcher();
#else
        = new(_FormatMatcherPattern, RegexOptions.Compiled);
#endif

    public static bool TryCompile(
        string? expression,
        [NotNullWhen(true)] out QuantityParseInfo? info)
    {
        expression ??= "";
        var match = _FormatMatcher.Match(expression);
        if (!match.Success)
        {
            info = default!;
            return false;
        }
        info = new(match.Groups["number"].Value, match.Groups["unit"].Value);
        return true;
    }
}