namespace NetQuantities;

[Quantity]
[QuantityUnit("MetrePerSecond", "m/s", 1.0)]
[QuantityOperation(typeof(QTime), typeof(QVelocity), typeof(QLength))]
public readonly partial struct QVelocity
{
}
