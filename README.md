# NetQuantities

.Net library for physical quantity handling

## Features

- naming rule
  - all types of quantity are named with `Q` prefix.
- based on International System of Units (SI)
- minimum overhead
  - quantity types are designed simple ValueObject wrapped `double` / `T` (for .Net 7 or later). - in most case there would be no overhead after JIT.
  - all types can be re-interpret casting to/from `double`/`T` (for .Net 7 or later, unmanaged type) as SI units.

## Usage

```CSharp
using NetQuantities;

QLength length = QLength.FromMetre(600);
QTime time = QTime.FromSecond(33.5);
QSpeed speed = length / time;
Console.WriteLine($"{speed}");
```
