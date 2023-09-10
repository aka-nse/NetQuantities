using System;
using System.Collections.Generic;
using System.Text;

namespace NetQuantities;

[Quantity]
[QuantityUnit("Kilometre", "km", 1.0e+3)]
[QuantityUnit("Metre", "m", 1.0)]
[QuantityUnit("Centimetre", "cm", 1.0e-2)]
[QuantityUnit("Millimetre", "mm", 1.0e-3)]
[QuantityUnit("Micrometre", "um", 1.0e-6)]
[QuantityUnit("Nanometre", "nm", 1.0e-9)]
public readonly partial struct QLength
{
}
