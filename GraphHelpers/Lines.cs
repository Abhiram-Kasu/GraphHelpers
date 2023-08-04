using MathNet.Numerics.LinearAlgebra;

namespace GraphHelpers;

/// <summary>
/// Contains static methods for calculating angles between points along a route.
/// </summary>
public static class Lines
{
    /// <summary>
    /// Calculates the angles between successive points along the provided route.
    /// </summary>
    /// <param name="points">The points defining the route.</param>
    /// <returns>A list of (point, angle) tuples for the calculated angles.</returns>
    public static IList<(PointD point, Angle angle)> GetAnglesForLine(IEnumerable<PointD> points) => GetAnglesForLine(points.ToArray());

    /// <summary>
    /// Calculates the angles between successive points along the provided route.
    /// </summary>
    /// <param name="points">The points defining the route.</param>
    /// <returns>A list of (points, angle) tuples for the calculated angles.</returns>
    public static IList<(PointD point, Angle angle)> GetAnglesForLine(PointD[] points)
    {
        var angles = new List<(PointD, Angle)>(points.Length - 2);

        for (var i = 0; i < points.Length - 2; i++)
        {
            angles.Add((points[i + 1], AngleHelper.Cos3Pnt(points[i..(i + 3)].Select(x => Vector<double>.Build.DenseOfArray(new[] { x.X, x.Y })).ToArray())));
        }

        return angles;
    }
}