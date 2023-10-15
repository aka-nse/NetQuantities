﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetQuantities.Generic;

namespace NetQuantities;

public class FormatTest
{
    public static IEnumerable<object[]> FormatTestCase()
    {
        static object[] core(IQuantity value, string format, CultureInfo? cultureInfo, string expected)
            => new object[] {value, format, cultureInfo ?? CultureInfo.InvariantCulture, expected, };

        yield return core(QSpeed.FromMetrePerSecond(1.234), "", null, "1.234m/s");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "&", null, "1.234m/s");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "& ", null, "1.234 m/s");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "&[]", null, "1.234[m/s]");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "& []", null, "1.234 [m/s]");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "E", null, "1.234000E+000m/s");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "E&", null, "1.234000E+000m/s");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "E& ", null, "1.234000E+000 m/s");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "E&[]", null, "1.234000E+000[m/s]");
        yield return core(QSpeed.FromMetrePerSecond(1.234), "E& []", null, "1.234000E+000 [m/s]");

        // yield return core(QSpeed<decimal>.FromMetrePerSecond(1.234m), "", null, "1.234m/s");

        yield break;
    }


    [Theory]
    [MemberData(nameof(FormatTestCase))]
    public void Format(IQuantity value, string format, CultureInfo cultureInfo, string expected)
    {
        var actual = value.ToString(format, cultureInfo);
        Assert.Equal(expected, actual);
    }
}