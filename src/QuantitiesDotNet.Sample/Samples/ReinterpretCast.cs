using System.Runtime.CompilerServices;

namespace QuantitiesDotNet.Samples;

internal class ReinterpretCast : IUsageSample
{
    public string SampleName => "reinterpret casting";

    public void Execute(TextWriter stdout)
    {
        var rawValueNonGeneric = 1.234;
        stdout.WriteLine(Unsafe.As<double, QSpeed>(ref rawValueNonGeneric));  // 1.234m/s

#if NET7_0_OR_GREATER
        var rawValueGeneric = 1.234m;
        stdout.WriteLine(Unsafe.As<decimal, Generic.QSpeed<decimal>>(ref rawValueGeneric));  // 1.234m/s
#endif
    }
}