# DimensionalExponents class

Supports conversion of measures from different forms of unit expression

```csharp
public class DimensionalExponents : IEquatable<DimensionalExponents>
```

## Public Members

| name | description |
| --- | --- |
| [DimensionalExponents](DimensionalExponents/DimensionalExponents.md)() | Unitless exponents, all values are 0. |
| [DimensionalExponents](DimensionalExponents/DimensionalExponents.md)(…) | Specifies exponent for all the base SI units involved; order of parameters is: 1) length, 2)mass, 3) time, 4) electricCurrent, 5) temperature, 6) amountOfSsubstance, 7) luminousIntensity |
| static [Elevated](DimensionalExponents/Elevated.md)(…) | Generates a new [`DimensionalExponents`](./DimensionalExponents.md) instance, elevating a starting one to the *exponent* power. |
| static [FromString](DimensionalExponents/FromString.md)(…) | New dimensional exponent from a string. |
| static [GetUnit](DimensionalExponents/GetUnit.md)(…) | Provides the DimensionalExponents of the base SI units. |
| [AmountOfSubstance](DimensionalExponents/AmountOfSubstance.md) { get; set; } | Dimensional exponent for the AmountOfSubstance core SI unit of measure |
| [ElectricCurrent](DimensionalExponents/ElectricCurrent.md) { get; set; } | Dimensional exponent for the ElectricCurrent core SI unit of measure |
| [Length](DimensionalExponents/Length.md) { get; set; } | Dimensional exponent for the Length core SI unit of measure |
| [LuminousIntensity](DimensionalExponents/LuminousIntensity.md) { get; set; } | Dimensional exponent for the LuminousIntensity core SI unit of measure |
| [Mass](DimensionalExponents/Mass.md) { get; set; } | Dimensional exponent for the Mass core SI unit of measure |
| [Temperature](DimensionalExponents/Temperature.md) { get; set; } | Dimensional exponent for the Temperature core SI unit of measure |
| [Time](DimensionalExponents/Time.md) { get; set; } | Dimensional exponent for the Time core SI unit of measure |
| [Elevate](DimensionalExponents/Elevate.md)(…) | elevates the current instance to the *exponent* power. |
| [Equals](DimensionalExponents/Equals.md)(…) |  |
| override [Equals](DimensionalExponents/Equals.md)(…) |  |
| [GetExponent](DimensionalExponents/GetExponent.md)(…) | Finds the exponent of one of the base SI units. |
| override [GetHashCode](DimensionalExponents/GetHashCode.md)() |  |
| [Multiply](DimensionalExponents/Multiply.md)(…) | Generates a new [`DimensionalExponents`](./DimensionalExponents.md) instance, resulting from the multiplication of the current instance with the *other*. |
| override [ToString](DimensionalExponents/ToString.md)() |  |
| [ToUnitSymbol](DimensionalExponents/ToUnitSymbol.md)() | String expression of the combination of exponets in the SI Units. |

## See Also

* namespace [IdsLib.IfcSchema](../ids-lib.md)
* [DimensionalExponents.cs](https://github.com/buildingSMART/IDS-Audit-tool/tree/main/ids-lib/IfcSchema/DimensionalExponents.cs)

<!-- DO NOT EDIT: generated by xmldocmd for ids-lib.dll -->