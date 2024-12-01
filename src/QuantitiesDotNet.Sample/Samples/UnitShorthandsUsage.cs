using static QuantitiesDotNet.UnitShorthands;

namespace QuantitiesDotNet.Samples;

internal class UnitShorthandsUsage : IUsageSample
{
    public string SampleName => "unit shorthands";

    public void Execute(TextWriter stdout)
    {
        stdout.WriteLine(1.234 * (kg));
        stdout.WriteLine(1.234 * (m));
        stdout.WriteLine(1.234 * (m / s));
    }
}