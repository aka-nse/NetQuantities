using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetQuantities.Generic;
namespace NetQuantities;

public class CreateTest
{
    [Fact]
    public void Create()
    {
        var speed = QSpeed<decimal>.FromMetrePerSecond(1);
        Assert.True(speed.RawValue == 1);
    }
}