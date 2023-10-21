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

    public string Format(string number, string unit)
    {
        var buffer = (stackalloc char[number.Length + Spacing.Length + (HasBrackets ? 2 : 0) + unit.Length]);
        Format(buffer, number, unit);
        return buffer.ToString();
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, string number, string unit)
    {
        var length = number.Length + Spacing.Length + (HasBrackets ? 2 : 0) + unit.Length;
        if (destination.Length < length)
        {
            charsWritten = default;
            return false;
        }
        charsWritten = Format(destination, number, unit);
        return true;
    }
    
    private int Format(Span<char> destination, string number, string unit)
    {
        var cursor = 0;
        number.AsSpan().CopyTo(destination.Slice(cursor));
        cursor += number.Length;
        Spacing.AsSpan().CopyTo(destination.Slice(cursor));
        cursor += Spacing.Length;
        if (HasBrackets)
        {
            destination[cursor] = '[';
            ++cursor;
        }
        unit.AsSpan().CopyTo(destination.Slice(cursor));
        cursor += unit.Length;
        if (HasBrackets)
        {
            destination[cursor] = ']';
            ++cursor;
        }
        return cursor;
    }
}