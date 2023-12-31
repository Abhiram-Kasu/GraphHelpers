# Graph Helpers

This C# project contains helper classes for working with graphs and geometry.

## Features

- [`Angle`](GraphHelpers/Angle.cs) - Represents an angle value with helper methods for converting between radians and degrees  
- [`AngleHelper`](GraphHelpers/AngleHelper.cs) - Contains methods for calculating angles between vectors
- [`Lines`](GraphHelpers/Lines.cs) - Calculates angles between successive points along a line
- [`PointD`](GraphHelpers/PointD.cs) - Represents a point in 2D space using double precision

## Usage

### Calculating angles along a route

```csharp
// Create sample points
var points = new[] 
{
  new PointD(0, 0),
  new PointD(1, 0), 
  new PointD(2, 1)
};

// Calculate angles
var angles = Lines.GetAnglesForLine(points);

// Print results
foreach (var (point, angle) in angles)
{
  Console.WriteLine($"At point {point}, angle is {angle.DegreeValue} degrees");
}
```
### Creating and manipulating angles
```csharp
// Create 90 degree angle 
var ninetyDeg = Angle.FromDegrees(90);

// Convert to radians
var ninetyRad = ninetyDeg.RadianValue;

// Add two angles
var sum = thirtyDeg + sixtyDeg;
```
----
## Classes

### [Angle](GraphHelpers/Angle.cs)

Represents an angle value in radians and degrees. Provides methods to:

- Create angles from radians or degrees
- Convert between units  
- Add angles together

### [AngleHelper](GraphHelpers/AngleHelper.cs)

Contains the `Cos3Pnt` method to calculate the angle between 3 vectors using the cosine formula.

### [Lines](GraphHelpers/Lines.cs)

Provides the `GetAnglesForLine` method to calculate angles between successive points along a route.

### [PointD](GraphHelpers/PointD.cs)

Represents a 2D point using double precision. Overloads operators like +, -, * for manipulating points.

## Installation

 - `PM > Install-Package GraphHelpers`
 -  `dotnet add package GraphHelpers --version 1.0.0`
 -  [NuGet Package Link](https://www.nuget.org/packages/GraphHelpers/)

## License

This project is licensed under the MIT license. See [LICENSE](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt) for details.
