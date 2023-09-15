using System;
namespace NetQuantities;

/// <summary>
/// Represents a value of dimensionless.
/// This type can be re-interpret-casted into <see cref="double"/> as [1] scale.
/// </summary>
[Quantity]
public readonly partial struct QDimensionless : IQuantity
{
    public static QDimensionless FromRaw(double rawValue) => new(rawValue);

    public static implicit operator double(QDimensionless self) => self.RawValue;

    public static implicit operator QDimensionless(double value) => new QDimensionless(value);
}
