using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuantitiesDotNet.Samples;

internal class QuantityInfos : IUsageSample
{
    public string SampleName => "shows quantity infos";

    public void Execute(TextWriter stdout)
    {
        var types = typeof(QuantityInfo).Assembly
            .GetTypes()
            .Where(t => t.IsValueType && !t.IsGenericType && typeof(IQuantity).IsAssignableFrom(t));
        foreach (var type in types)
        {
            var info = type.GetProperty(nameof(QDimensionless.Info), BindingFlags.Public | BindingFlags.Static)!.GetValue(null) as QuantityInfo;
            stdout.WriteLine($"{type.Name}: {info}");
        }
    }
}