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

### quantity dimension operation

```CSharp
using NetQuantities;

QLength length = QLength.FromMetre(600);
QTime time = QTime.FromSecond(33.5);
QSpeed speed = length / time;
Console.WriteLine($"{speed}");
```

### format

acceptable format: `<number>(&<spacing><unit>)?`

- `<number>`:<br/>
  You can use .Net format string for double.
- `&`:<br/>
  It is a separator of `<number>` and `<unit>`.
- `<spacing>`:<br/>
  If you put a whitespace after this separator, it is reflected into format result.
- `<unit>` (optional):<br/>
  It is a unit specifier.
  If you put square brackets (`[` and `]`) before and after this specifier, it is reflected into format result.

```CSharp
var speed = QSpeed.FromMetrePerSecond(1.234);
Console.WriteLine($"{speed}");                          // 1.234m/s
Console.WriteLine($"{speed:0.0}");                      // 1.2m/s
Console.WriteLine($"{speed:0.000&m/s}");                // 1.234m/s
Console.WriteLine($"{speed:0.000&km/h}");               // 4.442km/h
Console.WriteLine($"{speed:0.000&[m/s]}");              // 1.234[m/s]
Console.WriteLine($"{speed.ToString("0.000& m/s")}");   // 1.234 m/s
Console.WriteLine($"{speed.ToString("0.000& [m/s]")}"); // 1.234 [m/s]
```

### parse

acceptable expression: `<number>(<spacing><unit>)?`

- `<number>`:<br/>
  You can use parsable string for double.
- `<unit>` (optional):<br/>
  It is a unit specifier.
  You can put square brackets (`[` and `]`) before and after this specifier.

```CSharp
// all results: 1.234m/s
Console.WriteLine($"{QSpeed.Parse("1.234m/s", CultureInfo.InvariantCulture)}");
Console.WriteLine($"{QSpeed.Parse("4.4424km/h", CultureInfo.InvariantCulture):0.000}");
Console.WriteLine($"{QSpeed.Parse("1,234m/s", CultureInfo.GetCultureInfo("fr-FR"))}");
Console.WriteLine($"{QSpeed.Parse("1.234 m/s", CultureInfo.InvariantCulture)}");
Console.WriteLine($"{QSpeed.Parse("1.234[m/s]", CultureInfo.InvariantCulture)}");
Console.WriteLine($"{QSpeed.Parse("1.234 m/s", CultureInfo.InvariantCulture)}");

try
{
    Console.WriteLine($"{QSpeed.Parse("1.234", CultureInfo.InvariantCulture)}");
}
catch (FormatException)
{
    Console.WriteLine("You cannot omit unit.");
}
```

### generic math

If your project based on .Net7 or later, you can use generic version of quantity types.
They are declared in `NetQuantities.Generic` namespace, and you can use same APIs as non generic versions.

```CSharp
var lengthNonGeneric = NetQuantities.QLength.Parse("600.0 [m]", null);
var timeNonGeneric = NetQuantities.QTime.FromSecond(33.4);
var speedNonGeneric = lengthNonGeneric / timeNonGeneric;
Console.WriteLine(speedNonGeneric.ToString("0.00& m/s"));
Console.WriteLine(speedNonGeneric.RawValue.GetType());
// 17.96 m / s
// System.Double

var lengthGeneric = NetQuantities.Generic.QLength<decimal>.Parse("600.0 [m]", null);
var timeGeneric = NetQuantities.Generic.QTime<decimal>.FromSecond(33.4m);
var speedGeneric = lengthGeneric / timeGeneric;
Console.WriteLine(speedGeneric.ToString("0.00& m/s"));
Console.WriteLine(speedGeneric.RawValue.GetType());
// 17.96 m / s
// System.Decimal
```

### re-interpret casting

```CSharp
var rawValueNonGeneric = 1.234;
Console.WriteLine(Unsafe.As<double, NetQuantities.QSpeed>(ref rawValueNonGeneric));  // 1.234m/s

var rawValueGeneric = 1.234m;
Console.WriteLine(Unsafe.As<decimal, NetQuantities.Generic.QSpeed<decimal>>(ref rawValueGeneric));  // 1.234m/s
```