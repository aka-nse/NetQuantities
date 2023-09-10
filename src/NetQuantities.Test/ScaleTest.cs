namespace NetQuantities;

public class ScaleTest
{
    [Fact]
    public void Scale_QDimensionless()
    {
        var q = QDimensionless.FromRaw(1);
        Assert.Equal(1.0, q.RawValue);
    }

    [Fact]
    public void Scale_QTime()
    {
        Assert.Equal(1.0, QTime.FromSecond(1).RawValue);
        Assert.Equal(1.0, QTime.FromSecond(1).Second);

        Assert.Equal(1.0e-3, QTime.FromMillisecond(1).Second, precision: 10);
        Assert.Equal(1.0, QTime.FromMillisecond(1).Millisecond, precision: 10);

        Assert.Equal(60.0, QTime.FromMinute(1).Second, precision: 10);
        Assert.Equal(1.0, QTime.FromMinute(1).Minute, precision: 10);

        Assert.Equal(3600.0, QTime.FromHour(1).Second, precision: 10);
        Assert.Equal(1.0, QTime.FromHour(1).Hour, precision: 10);
    }

    [Fact]
    public void Scale_Qlength()
    {
        Assert.Equal(1.0, QLength.FromMetre(1).RawValue);
        Assert.Equal(1.0, QLength.FromMetre(1).Metre);

        Assert.Equal(1.0e-9, QLength.FromNanometre(1).Metre, precision: 10);
        Assert.Equal(1.0, QLength.FromNanometre(1).Nanometre, precision: 10);

        Assert.Equal(1.0e-6, QLength.FromMicrometre(1).Metre, precision: 10);
        Assert.Equal(1.0, QLength.FromMicrometre(1).Micrometre, precision: 10);

        Assert.Equal(1.0e-3, QLength.FromMillimetre(1).Metre, precision: 10);
        Assert.Equal(1.0, QLength.FromMillimetre(1).Millimetre, precision: 10);

        Assert.Equal(1.0e-2, QLength.FromCentimetre(1).Metre, precision: 10);
        Assert.Equal(1.0, QLength.FromCentimetre(1).Centimetre, precision: 10);

        Assert.Equal(1.0e+3, QLength.FromKilometre(1).Metre, precision: 10);
        Assert.Equal(1.0, QLength.FromKilometre(1).Kilometre, precision: 10);
    }

    [Fact]
    public void Scale_QVelocity()
    {
        Assert.Equal(1.0, QVelocity.FromMetrePerSecond(1).RawValue);
        Assert.Equal(1.0, QVelocity.FromMetrePerSecond(1).MetrePerSecond);

        Assert.Equal(1.0e-3, QVelocity.FromMillimetrePerSecond(1).MetrePerSecond, precision: 10);
        Assert.Equal(1.0, QVelocity.FromMillimetrePerSecond(1).MillimetrePerSecond, precision: 10);
        
        Assert.Equal(1.0e-6, QVelocity.FromMicrometrePerSecond(1).MetrePerSecond);
        Assert.Equal(1.0, QVelocity.FromMicrometrePerSecond(1).MicrometrePerSecond, precision: 10);
        
        Assert.Equal(1.0/60, QVelocity.FromMetrePerMinute(1).MetrePerSecond, precision: 10);
        Assert.Equal(1.0, QVelocity.FromMetrePerMinute(1).MetrePerMinute, precision: 10);

        Assert.Equal(1.0e+3/3600, QVelocity.FromKilometrePerHour(1).MetrePerSecond, precision: 10);
        Assert.Equal(1.0, QVelocity.FromKilometrePerHour(1).KilometrePerHour, precision: 10);


    }
}
