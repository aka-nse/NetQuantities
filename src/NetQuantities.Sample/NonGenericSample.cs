using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetQuantities;

public static class NonGenericSample
{
    public static void Run()
    {
        var length = QLength.FromMetre(600);
        var time = QTime.FromSecond(33.5);
        var speed = length / time;
        Console.WriteLine($"{speed:0.00& [km/h]}");
    }
}