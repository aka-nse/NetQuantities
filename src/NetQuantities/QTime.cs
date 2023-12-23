using System;
using static NetQuantities.UnitPrefix;

namespace NetQuantities;

/// <summary>
/// Represents a value of time.
/// This type can be re-interpret-casted into <see cref="double"/> as [s] scale.
/// </summary>
[Quantity]
[QuantityUnit("Second", "s", 1.0, None | Milli | Micro | Nano | Pico | Femto, exportsShorthandSymbol: true)]
[QuantityUnit("Minute", "min", 60.0, exportsShorthandSymbol: true)]
[QuantityUnit("Hour", "h", 3600.0, exportsShorthandSymbol: true)]
public readonly partial struct QTime : IQuantity<QTime>
{
    /// <summary>
    /// Converts from <see cref="QTime"/> to <see cref="TimeSpan"/>.
    /// </summary>
    /// <param name="time"></param>
    public static explicit operator TimeSpan(QTime time)
        => TimeSpan.FromSeconds(time.Second);

    /// <summary>
    /// Converts from <see cref="TimeSpan"/> to <see cref="QTime"/>.
    /// </summary>
    /// <param name="time"></param>
    public static explicit operator QTime(TimeSpan time)
        => FromSecond(time.TotalSeconds);
}
