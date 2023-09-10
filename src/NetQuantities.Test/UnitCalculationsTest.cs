namespace NetQuantities;

public class UnitCalculationsTest
{
    [Fact]
    public void Test()
    {
        var ‚” = QTime.FromSecond(1);
        var ‚– = QVelocity.FromMetrePerSecond(1);
        var ‚˜ = QLength.FromMetre(1);

        Assert.Equal(‚–, ‚˜ / ‚”);
        Assert.Equal(‚”, ‚˜ / ‚–);
        Assert.Equal(‚˜, ‚” * ‚–);
        Assert.Equal(‚˜, ‚– * ‚”);
    }
}