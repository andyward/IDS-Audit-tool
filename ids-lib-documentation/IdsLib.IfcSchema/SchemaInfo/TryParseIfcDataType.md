# SchemaInfo.TryParseIfcDataType method

Attempts to convert a string value to an instance of the IfcMeasureInformation

```csharp
public static bool TryParseIfcDataType(string value, out IfcDataTypeInformation? found, 
    bool strict = true)
```

| parameter | description |
| --- | --- |
| value | the dataType string to parse |
| found |  |
| strict | if true only accepts capitalized data, otherwise tolerates case inconsistencies |

## Return Value

true if a match is found

## See Also

* class [IfcDataTypeInformation](../IfcDataTypeInformation.md)
* class [SchemaInfo](../SchemaInfo.md)
* namespace [IdsLib.IfcSchema](../../ids-lib.md)

<!-- DO NOT EDIT: generated by xmldocmd for ids-lib.dll -->
