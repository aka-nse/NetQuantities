using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NetQuantities.Samples;

internal class QuantityInfos : IUsageSample
{
    public string SampleName => "shows quantity infos";

    public void Execute(TextWriter stdout)
    {
        const BindingFlags flags =
            BindingFlags.NonPublic | BindingFlags.Static;

        var types = typeof(QuantityInfo).Assembly
            .GetTypes()
            .Where(t => t.IsValueType
                && !t.IsGenericType
                && t.GetCustomAttributes().Any(x => x.GetType().Name == "QuantityAttribute"));
        var infos = new List<QuantityInfo>();
        foreach (var type in types)
        {
            // for reflection of ref struct, explicitly named backing field is provided.
            var info = type.GetField(nameof(QDimensionless._Info), flags)!.GetValue(null) as QuantityInfo;
            infos.Add(info!);

            // stdout.WriteLine($"{type.Name}: {info}");
        }

        void isConflict(int L, int M, int T, int I, int Th, int N, int J)
        {
            var has = infos!.Any(x => x.Dimension == new QuantityInfo.DimensionInfo(L, M, T, I, Th, N, J));
            stdout.WriteLine($"{has,5} <= L :{L,2}, M :{M,2}, T :{T,2}, I :{I,2}, Th:{Th,2}, N :{N,2}, J :{J,2}");
        }

        isConflict(L: 1, M: 1, T: 0, I: 0, Th: 0, N: 0, J: 0);
        isConflict(L: 1, M: 0, T: 1, I: 0, Th: 0, N: 0, J: 0);
    }

}