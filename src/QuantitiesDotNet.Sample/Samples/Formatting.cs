namespace QuantitiesDotNet.Samples;

internal class Formatting : IUsageSample
{
    public string SampleName => "string formatting";

    public void Execute(TextWriter stdout)
    {
        var speed = QSpeed.FromMetrePerSecond(1.234);
        stdout.WriteLine($"{speed}");                          // 1.234m/s
        stdout.WriteLine($"{speed:0.0}");                      // 1.2m/s
        stdout.WriteLine($"{speed:0.000&m/s}");                // 1.234m/s
        stdout.WriteLine($"{speed:0.000&km/h}");               // 4.442km/h
        stdout.WriteLine($"{speed:0.000&[m/s]}");              // 1.234[m/s]
        stdout.WriteLine($"{speed.ToString("0.000& m/s")}");   // 1.234 m/s
        stdout.WriteLine($"{speed.ToString("0.000& [m/s]")}"); // 1.234 [m/s]
    }
}