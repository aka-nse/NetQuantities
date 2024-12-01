using QuantitiesDotNet.Generic;

namespace QuantitiesDotNet;

public class ParseTest
{
#pragma warning disable format
    public static IEnumerable<object?[]> ParseTestCase()
    {
        static object?[] core(string expression, QSpeed? expected)
            => new object?[] { expression, expected, };

        yield return core("1.234m/s"           , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234m/s"           , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234 m/s"          , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234[m/s]"         , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234 [m/s]"        , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234000E+000m/s"   , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234000E+000m/s"   , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234000E+000 m/s"  , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234000E+000[m/s]" , QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234000E+000 [m/s]", QSpeed.FromMetrePerSecond(1.234));
        yield return core("1.234000E+000 [m/s", null);

        yield break;
    }

    public static IEnumerable<object?[]> ParseGenericTestCase()
    {
        static object?[] core(string expression, QSpeed<decimal>? expected)
            => new object?[] { expression, expected, };

        yield return core("1.234m/s"           , QSpeed<decimal>.FromMetrePerSecond(1.234m));
        yield return core("1.234m/s"           , QSpeed<decimal>.FromMetrePerSecond(1.234m));
        yield return core("1.234 m/s"          , QSpeed<decimal>.FromMetrePerSecond(1.234m));
        yield return core("1.234[m/s]"         , QSpeed<decimal>.FromMetrePerSecond(1.234m));
        yield return core("1.234 [m/s]"        , QSpeed<decimal>.FromMetrePerSecond(1.234m));
        yield return core("1.234 [m/s" , null);

        yield break;
    }
#pragma warning restore format

    [Theory]
    [MemberData(nameof(ParseTestCase))]
    public void Parse(string expression, QSpeed? expected)
    {
        if (expected is QSpeed expected_)
        {
            Assert.True(QSpeed.TryParse(expression, null, out var actual));
            Assert.Equal(expected_, actual);
            Assert.Equal(expected_, QSpeed.Parse(expression, null));
        }
        else
        {
            Assert.False(QSpeed.TryParse(expression, null, out _));
            Assert.Throws<FormatException>(() => QSpeed.Parse(expression, null));
        }
    }

    [Theory]
    [MemberData(nameof(ParseGenericTestCase))]
    public void ParseGeneric(string expression, QSpeed<decimal>? expected)
    {
        if (expected is QSpeed<decimal> expected_)
        {
            Assert.True(QSpeed<decimal>.TryParse(expression, null, out var actual));
            Assert.Equal(expected_, actual);
            Assert.Equal(expected_, QSpeed<decimal>.Parse(expression, null));
        }
        else
        {
            Assert.False(QSpeed<decimal>.TryParse(expression, null, out _));
            Assert.Throws<FormatException>(() => QSpeed<decimal>.Parse(expression, null));
        }
    }
}