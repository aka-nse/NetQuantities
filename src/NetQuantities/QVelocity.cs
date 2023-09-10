using System.Numerics;

namespace NetQuantities;

[Quantity]
[QuantityUnit("MetrePerSecond", "m/s", 1.0)]
[QuantityUnit("MillimetrePerSecond", "mm/s", 1.0e-3)]
[QuantityUnit("MicrometrePerSecond", "um/s", 1.0e-6)]
[QuantityUnit("MetrePerMinute", "m/min", 1.0 / 60)]
[QuantityUnit("KilometrePerHour", "km/h", 1.0e+3 / 3600)]
[QuantityOperation(typeof(QTime), typeof(QVelocity), typeof(QLength))]
public readonly partial struct QVelocity
{
}
