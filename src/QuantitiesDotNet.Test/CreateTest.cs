using QuantitiesDotNet.Generic;

namespace QuantitiesDotNet;

public class CreateTest
{
    [Fact]
    public void Create()
    {
        var speed = QSpeed<decimal>.FromMetrePerSecond(1);
        Assert.True(speed.RawValue == 1);
    }
}