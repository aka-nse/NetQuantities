﻿using System.Reflection;

namespace QuantitiesDotNet;

public class DimensionTest
{
    public record ValidateDimensionCalculationTestCase(
        QuantityInfo Ans,
        QuantityInfo Lhs,
        QuantityInfo Rhs)
    {
        public override string ToString()
            => $"{Ans.Name} = {Lhs.Name} * {Rhs.Name}";
    }

    public static IEnumerable<object[]> ValidateDimensionCalculationTestCases()
    {
        static QuantityInfo? getInfo(Type type)
            => type
                .GetProperty(nameof(QDimensionless.Info), BindingFlags.Public | BindingFlags.Static)
                ?.GetValue(null) as QuantityInfo;

        var types = typeof(QuantityInfo).Assembly
            .GetTypes()
            .Where(t => t.IsValueType)
            .Where(t => !t.IsGenericType)
            .Where(t => typeof(IQuantity).IsAssignableFrom(t));
        foreach (var type in types)
        {
            var methods = type.GetMethods();
            foreach (var mi in methods)
            {
                if (mi.Name != "op_Multiply") { continue; }
                if (!typeof(IQuantity).IsAssignableFrom(mi.ReturnType)) { continue; }
                if (!typeof(IQuantity).IsAssignableFrom(mi.GetParameters()[0].ParameterType)) { continue; }
                if (!typeof(IQuantity).IsAssignableFrom(mi.GetParameters()[1].ParameterType)) { continue; }

                var ans = getInfo(mi.ReturnType)!;
                var lhs = getInfo(mi.GetParameters()[0].ParameterType)!;
                var rhs = getInfo(mi.GetParameters()[1].ParameterType)!;
                yield return new object[] { new ValidateDimensionCalculationTestCase(ans, lhs, rhs), };
            }
        }
    }


    [Theory]
    [MemberData(nameof(ValidateDimensionCalculationTestCases))]
    public void ValidateDimensionCalculation(ValidateDimensionCalculationTestCase testCase)
    {
        var (ans, lhs, rhs) = testCase;
        Assert.Equal(ans.Dimension.L, lhs.Dimension.L + rhs.Dimension.L);
        Assert.Equal(ans.Dimension.M, lhs.Dimension.M + rhs.Dimension.M);
        Assert.Equal(ans.Dimension.T, lhs.Dimension.T + rhs.Dimension.T);
        Assert.Equal(ans.Dimension.I, lhs.Dimension.I + rhs.Dimension.I);
        Assert.Equal(ans.Dimension.Th, lhs.Dimension.Th + rhs.Dimension.Th);
        Assert.Equal(ans.Dimension.N, lhs.Dimension.N + rhs.Dimension.N);
        Assert.Equal(ans.Dimension.J, lhs.Dimension.J + rhs.Dimension.J);
    }
}