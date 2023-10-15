using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;

namespace NetQuantities;

internal record QuantityFormatInfo(
    string NumberFormat,
    string Spacing,
    string UnitSelector,
    bool HasBrackets)
{
    private static readonly Regex _EscapeMatcher
        = new(@"\\(.)");

    private static readonly Regex _FormatMatcher
        = new(@"^(?<number>(?:[^\s&]|\\.)*)(?:&(?<spacing>\s*)(?<open>\[?)(?<unit>(?:[^\s\[\]]|\\.)*)(?<close>\]?))?$");

    public static bool TryParse(
        string? format,
        [NotNullWhen(true)] out QuantityFormatInfo? info)
    {
        info = default!;
        format ??= "";
        var match = _FormatMatcher.Match(format);
        if (!match.Success)
        {
            return false;
        }
        bool hasBrackets;
        switch ((match.Groups["open"].Value, match.Groups["close"].Value))
        {
            case ("", ""):
                hasBrackets = false;
                break;
            case ("[", "]"):
                hasBrackets = true;
                break;
            default:
                return false;
        }
        info = new(
            _EscapeMatcher.Replace(match.Groups["number"].Value, "$1"),
            match.Groups["spacing"].Value,
            _EscapeMatcher.Replace(match.Groups["unit"].Value, "$1"),
            hasBrackets);
        return true;
    }
}