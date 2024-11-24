namespace QuantitiesDotNet;

internal interface IUsageSample
{
    public string SampleName { get; }
    public void Execute(TextWriter stdout);
}