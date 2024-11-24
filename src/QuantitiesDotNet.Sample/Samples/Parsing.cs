using System.Globalization;

namespace QuantitiesDotNet.Samples;

internal class Parsing : IUsageSample
{
    public string SampleName => "string parsing";

    public void Execute(TextWriter stdout)
    {
        // all results: 1.234m/s
        stdout.WriteLine($"{QSpeed.Parse("1.234m/s", CultureInfo.InvariantCulture)}");
        stdout.WriteLine($"{QSpeed.Parse("4.4424km/h", CultureInfo.InvariantCulture):0.000}");
        stdout.WriteLine($"{QSpeed.Parse("1,234m/s", CultureInfo.GetCultureInfo("fr-FR"))}");
        stdout.WriteLine($"{QSpeed.Parse("1.234 m/s", CultureInfo.InvariantCulture)}");
        stdout.WriteLine($"{QSpeed.Parse("1.234[m/s]", CultureInfo.InvariantCulture)}");
        stdout.WriteLine($"{QSpeed.Parse("1.234 m/s", CultureInfo.InvariantCulture)}");

        try
        {
            stdout.WriteLine($"{QSpeed.Parse("1.234", CultureInfo.InvariantCulture)}");
        }
        catch (FormatException)
        {
            stdout.WriteLine("You cannot omit unit.");
        }
    }
}