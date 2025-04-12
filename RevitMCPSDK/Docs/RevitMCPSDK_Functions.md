# RevitMCPSDK Functions Catalog

## Exceptions

### CommandExecutionException

- Constructors:

  1. `CommandExecutionException(string message)`
  2. `CommandExecutionException(string message, int errorCode)`
  3. `CommandExecutionException(string message, int errorCode, object errorData)`

- Properties:
  - `ErrorCode`: int
  - `ErrorData`: object

### ConfigurationException

- Constructors:
  1. `ConfigurationException(string message)`
  2. `ConfigurationException(string message, Exception innerException)`

## API Extensions

### DocumentExtensions

- Purpose: Provides utility methods for working with Revit Documents
- Key Methods:
  1. `FindNearestLevel(double elevation)`: Finds the closest level to a given elevation
     - Parameters:
       - `elevation`: Target elevation in feet
     - Returns: `Level` closest to the specified elevation
     - Returns `null` if no levels exist
     - Handles `null` document input

### MathExtensions

- Purpose: Provides mathematical and unit conversion utilities
- Constants:

  - `MM_TO_FEET`: Conversion factor from millimeters to feet
  - `FEET_TO_MM`: Conversion factor from feet to millimeters
  - `INCH_TO_FEET`: Conversion factor from inches to feet
  - `FEET_TO_INCH`: Conversion factor from feet to inches

- Key Methods:

  1. Unit Conversion Methods:

     - `ToFeet()`: Converts millimeters to feet
     - `ToMillimeters()`: Converts feet to millimeters
     - `InchesToFeet()`: Converts inches to feet
     - `FeetToInches()`: Converts feet to inches

  2. `RoundToDecimals(int decimals)`: Rounds a value to specified decimal places

     - Provides precise control over numeric precision

  3. `IsAlmostEqual(double target, double tolerance = 1e-9)`: Compares values with tolerance

     - Useful for floating-point comparisons
     - Default tolerance prevents precision issues

  4. `Clamp(double min, double max)`: Constrains a value between minimum and maximum
     - Ensures values stay within a specified range