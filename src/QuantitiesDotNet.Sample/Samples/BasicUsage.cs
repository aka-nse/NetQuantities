namespace QuantitiesDotNet.Samples;

internal class BasicUsage : IUsageSample
{
    public string SampleName => "basic usage";

    public void Execute(TextWriter stdout)
    {
        var length = QLength.FromMetre(600);
        var time = QTime.FromSecond(33.5);
        var speed = length / time;
        stdout.WriteLine($"{speed:0.00& [km/h]}");
    }
}