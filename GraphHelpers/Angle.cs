namespace GraphHelpers;

/// <summary>
/// Represents an angle value with utility methods.
/// </summary>
public readonly struct Angle
{
    /// <summary>
    /// The angle value in radians.
    /// </summary>
    public double RadianValue { get; init; }

    /// <summary>
    /// The angle value in degrees.
    /// </summary>
    public double DegreeValue { get; init; }

    /// <summary>
    /// Converts an angle from radians to degrees.
    /// </summary>
    /// <param name="radian">The angle in radians.</param>
    /// <returns>The angle in degrees.</returns>
    private static double ConvertRadianToDegree(double radian)
    {
        return radian * 180.0 / Math.PI;
    }

    /// <summary>
    /// Converts an angle from degrees to radians.
    /// </summary>
    /// <param name="degree">The angle in degrees.</param>
    /// <returns>The angle in radians.</returns>
    private static double ConvertDegreeToRadian(double degree)
    {
        return degree * Math.PI / 180.0;
    }

    /// <summary>
    /// Gets the unit type of the angle.
    /// </summary>
    public AngleTypes AngleType { get; init; }

    /// <summary>
    /// Creates an Angle from a radian value.
    /// </summary>
    /// <param name="radians">The angle in radians.</param>
    /// <returns>The Angle object.</returns>
    public static Angle FromRadians(double radians)
    {
        return new Angle
        {
            RadianValue = radians,
            DegreeValue = ConvertRadianToDegree(radians),
            AngleType = AngleTypes.Radian
        };
    }

    /// <summary>
    /// Creates an Angle from a degree value.
    /// </summary>
    /// <param name="degrees">The angle in degrees.</param>
    /// <returns>The Angle object.</returns>
    public static Angle FromDegrees(double degrees)
    {
        return new Angle
        {
            DegreeValue = degrees,
            RadianValue = ConvertDegreeToRadian(degrees),
            AngleType = AngleTypes.Degree
        };
    }

    /// <summary>
    /// Creates an Angle from a numeric value and unit type.
    /// </summary>
    /// <param name="value">The angle value.</param>
    /// <param name="angleType">The unit type.</param>
    /// <returns>The Angle object.</returns>
    /// <exception cref="ArgumentException">If invalid angleType.</exception>
    public static Angle From(double value, AngleTypes angleType)
    {
        return angleType switch
        {
            AngleTypes.Radian => FromRadians(value),
            AngleTypes.Degree => FromDegrees(value),
            _ => throw new ArgumentException("Invalid Angle Type", nameof(angleType))
        };
    }

    /// <summary>
    /// Adds two Angle values.
    /// </summary>
    /// <param name="a">The first angle.</param>
    /// <param name="b">The second angle.</param>
    /// <returns>The sum of the two angles.</returns>
    public static Angle operator +(Angle a, Angle b)
    {
        return new Angle
        {
            DegreeValue = a.DegreeValue + b.DegreeValue,
            RadianValue = a.RadianValue + b.RadianValue
        };
    }

    // Other operators

    /// <summary>
    /// The supported angle units.
    /// </summary>
    public enum AngleTypes
    {
        /// <summary>
        /// The radian unit.
        /// </summary>
        Radian,

        /// <summary>
        /// The degree unit.
        /// </summary>
        Degree
    }
}