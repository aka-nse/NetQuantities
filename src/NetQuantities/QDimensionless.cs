using System;
using System.Collections.Generic;
using System.Text;

namespace NetQuantities;

[Quantity]
public readonly partial struct QDimensionless
    : IQuantity
{
    public static QDimensionless FromRaw(double rawValue) => new(rawValue);

    public static implicit operator double(QDimensionless self) => self.RawValue;

    public static implicit operator QDimensionless(double value) => new QDimensionless(value);
}
