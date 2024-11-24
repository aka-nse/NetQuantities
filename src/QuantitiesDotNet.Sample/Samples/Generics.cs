namespace QuantitiesDotNet.Samples;

internal class Generics : IUsageSample
{
    public string SampleName => "generic types (.Net 7 or greater only)";

    public void Execute(TextWriter stdout)
    {
#if NET7_0_OR_GREATER
        var lengthNonGeneric = QLength.Parse("600.0 [m]", null);
        var timeNonGeneric = QTime.FromSecond(33.4);
        var speedNonGeneric = lengthNonGeneric / timeNonGeneric;
        stdout.WriteLine(speedNonGeneric.ToString("0.00& m/s"));
        stdout.WriteLine(speedNonGeneric.RawValue.GetType());
        // 17.96 m / s
        // System.Double

        var lengthGeneric = Generic.QLength<decimal>.Parse("600.0 [m]", null);
        var timeGeneric = Generic.QTime<decimal>.FromSecond(33.4m);
        var speedGeneric = lengthGeneric / timeGeneric;
        stdout.WriteLine(speedGeneric.ToString("0.00& m/s"));
        stdout.WriteLine(speedGeneric.RawValue.GetType());
        // 17.96 m / s
        // System.Decimal
#endif
    }
}