namespace GraphHelpers;

/// <summary>
/// Represents a point in 2D space using double precision values.
/// </summary>
public struct PointD
{
    /// <summary>
    /// The X coordinate of the point.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// The Y coordinate of the point.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Initializes a new instance of the PointD struct.
    /// </summary>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    public PointD(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Adds two PointD objects together.
    /// </summary>
    /// <param name="p1">The first point.</param>
    /// <param name="p2">The second point.</param>
    /// <returns>A new PointD representing the sum.</returns>
    public static PointD operator +(PointD p1, PointD p2)
    {
        return new PointD(p1.X + p2.X, p1.Y + p2.Y);
    }

    /// <summary>
    /// Subtracts one PointD from another.
    /// </summary>
    /// <param name="p1">The point to subtract from.</param>
    /// <param name="p2">The point to subtract.</param>
    /// <returns>A new PointD representing the difference.</returns>
    public static PointD operator -(PointD p1, PointD p2)
    {
        return new PointD(p1.X - p2.X, p1.Y - p2.Y);
    }

    /// <summary>
    /// Multiplies a PointD by a scalar value.
    /// </summary>
    /// <param name="p">The point.</param>
    /// <param name="value">The scalar value.</param>
    /// <returns>A new scaled PointD.</returns>
    public static PointD operator *(PointD p, double value)
    {
        return new PointD(p.X * value, p.Y * value);
    }

    /// <summary>
    /// Divides a PointD by a scalar value.
    /// </summary>
    /// <param name="p">The point.</param>
    /// <param name="value">The scalar value.</param>
    /// <returns>A new scaled PointD.</returns>
    public static PointD operator /(PointD p, double value)
    {
        return new PointD(p.X / value, p.Y / value);
    }

    /// <summary>
    /// Deconstructs the PointD into its individual x and y components.
    /// </summary>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    public void Deconstruct(out double x, out double y)
    {
        x = X;
        y = Y;
    }
}