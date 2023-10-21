#if NET7_0_OR_GREATER
using NetQuantities.Generic;
#endif
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetQuantities;

public static class GenericSample
{
    public static void Run()
    {
#if NET7_0_OR_GREATER
        var length = QLength<decimal>.FromMetre(600m);
        var time = QTime<decimal>.FromSecond(33.5m);
        var speed = length / time;
        Console.WriteLine($"{speed:0.00& [km/h]}");
#endif
    }
}