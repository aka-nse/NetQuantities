using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetQuantities;

public static class SampleMethods
{
    public static void BasicUsageSample()
    {
        var length = QLength.FromMetre(600);
        var time = QTime.FromSecond(33.5);
        var speed = length / time;
        Console.WriteLine($"{speed:0.00& [km/h]}");
    }

    public static void FormatSample()
    {
        var speed = QSpeed.FromMetrePerSecond(1.234);
        Console.WriteLine($"{speed}");                          // 1.234m/s
        Console.WriteLine($"{speed:0.0}");                      // 1.2m/s
        Console.WriteLine($"{speed:0.000&m/s}");                // 1.234m/s
        Console.WriteLine($"{speed:0.000&km/h}");               // 4.442km/h
        Console.WriteLine($"{speed:0.000&[m/s]}");              // 1.234[m/s]
        Console.WriteLine($"{speed.ToString("0.000& m/s")}");   // 1.234 m/s
        Console.WriteLine($"{speed.ToString("0.000& [m/s]")}"); // 1.234 [m/s]
    }

    public static void ParseSample()
    {
        // all results: 1.234m/s
        Console.WriteLine($"{QSpeed.Parse("1.234m/s", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"{QSpeed.Parse("4.4424km/h", CultureInfo.InvariantCulture):0.000}");
        Console.WriteLine($"{QSpeed.Parse("1,234m/s", CultureInfo.GetCultureInfo("fr-FR"))}");
        Console.WriteLine($"{QSpeed.Parse("1.234 m/s", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"{QSpeed.Parse("1.234[m/s]", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"{QSpeed.Parse("1.234 m/s", CultureInfo.InvariantCulture)}");

        try
        {
            Console.WriteLine($"{QSpeed.Parse("1.234", CultureInfo.InvariantCulture)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("You cannot omit unit.");
        }
    }

    public static void ReinterpretCastSample()
    {
        var rawValueNonGeneric = 1.234;
        Console.WriteLine(Unsafe.As<double, NetQuantities.QSpeed>(ref rawValueNonGeneric));  // 1.234m/s

        var rawValueGeneric = 1.234m;
        Console.WriteLine(Unsafe.As<decimal, NetQuantities.Generic.QSpeed<decimal>>(ref rawValueGeneric));  // 1.234m/s
    }

    public static void GenericSample()
    {
        var lengthNonGeneric = NetQuantities.QLength.Parse("600.0 [m]", null);
        var timeNonGeneric = NetQuantities.QTime.FromSecond(33.4);
        var speedNonGeneric = lengthNonGeneric / timeNonGeneric;
        Console.WriteLine(speedNonGeneric.ToString("0.00& m/s"));
        Console.WriteLine(speedNonGeneric.RawValue.GetType());
        // 17.96 m / s
        // System.Double

        var lengthGeneric = NetQuantities.Generic.QLength<decimal>.Parse("600.0 [m]", null);
        var timeGeneric = NetQuantities.Generic.QTime<decimal>.FromSecond(33.4m);
        var speedGeneric = lengthGeneric / timeGeneric;
        Console.WriteLine(speedGeneric.ToString("0.00& m/s"));
        Console.WriteLine(speedGeneric.RawValue.GetType());
        // 17.96 m / s
        // System.Decimal
    }
}