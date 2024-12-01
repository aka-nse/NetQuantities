namespace QuantitiesDotNet;

public class QuantityFormatInfoTest
{
    public static IEnumerable<object?[]> TryParseTestCases()
    {
        static object?[] core(string format, QuantityFormatInfo? expectedResult)
            => new object?[] { format, expectedResult };

        yield return core("", new("", "", "", false));
        yield return core("0", new("0", "", "", false));
        yield return core("E", new("E", "", "", false));
        yield return core("&", new("", "", "", false));
        yield return core("0&", new("0", "", "", false));
        yield return core("E&", new("E", "", "", false));
        yield return core("&m/s", new("", "", "m/s", false));
        yield return core("&[m/s]", new("", "", "m/s", true));
        yield return core("E&m/s", new("E", "", "m/s", false));
        yield return core("E&[m/s]", new("E", "", "m/s", true));
        yield return core("E3&m/s", new("E3", "", "m/s", false));
        yield return core("E3&[m/s]", new("E3", "", "m/s", true));
        yield return core("0.00&m/s", new("0.00", "", "m/s", false));
        yield return core("0.00&[m/s]", new("0.00", "", "m/s", true));
        yield return core("0.00& m/s", new("0.00", " ", "m/s", false));
        yield return core("0.00& [m/s]", new("0.00", " ", "m/s", true));
        yield return core("0.00\\&a& [m/s]", new("0.00&a", " ", "m/s", true));
        yield return core("0.00\\&a& [m/s\\[\\]]", new("0.00&a", " ", "m/s[]", true));
        yield break;
    }

    [Theory]
    [MemberData(nameof(TryParseTestCases))]
    public void TryParse(string format, object? expectedResult)
    {
        var actualSucceeded = QuantityFormatInfo.TryCompile(format, out var actualResult);
        if (expectedResult is QuantityFormatInfo expectedResult_)
        {
            Assert.True(actualSucceeded);
            Assert.Equal(expectedResult_, actualResult);
        }
        else
        {
            Assert.False(actualSucceeded);
        }
    }
}