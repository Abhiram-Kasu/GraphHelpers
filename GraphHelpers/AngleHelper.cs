using MathNet.Numerics.LinearAlgebra;

namespace GraphHelpers;

/// <summary>
/// Contains helper methods for calculating angles between vectors.
/// </summary>
internal static class AngleHelper
{
    /// <summary>
    /// Calculates the angle between 3 vectors using the cosine formula.
    /// </summary>
    /// <param name="v">The 3 vectors to calculate the angle between.</param>
    /// <returns>The calculated angle.</returns>
    /// <exception cref="ArgumentException">If v does not contain exactly 3 vectors.</exception>
    public static Angle Cos3Pnt(Vector<double>[] v)
    {
        return v.Length switch
        {
            > 3 => throw new ArgumentException("Too many parameters"),
            < 3 => throw new ArgumentException("Too little parameters"),
            _ => Cos3Pnt(v[0], v[1], v[2])
        };
    }

    /// <summary>
    /// Calculates the angle between 3 vectors using the cosine formula.
    /// Translated from python code written by DanPatterson_Retired
    /// </summary>
    /// <remarks>
    /// This code was originally written in python by DanPatterson_Retired as the answer to this question: Calculate Bends in a Line
    /// at https://community.esri.com/t5/python-questions/calculate-bends-in-a-line/m-p/745475#M57626
    /// and translated into C# by me.
    /// </remarks>
    /// <param name="a">The first vector.</param>
    /// <param name="b">The second vector.</param>
    /// <param name="c">The third vector.</param>
    /// <returns>The calculated angle.</returns>
    public static Angle Cos3Pnt(Vector<double> a, Vector<double> b, Vector<double> c)
    {
        var ba = a - b;
        var bc = c - b;

        var cosA = ba.DotProduct(bc) / (ba.L2Norm() * bc.L2Norm());

        var angle = Math.Acos(cosA);

        if (Math.Abs(angle - Math.PI) < 1e-9)
            return Angle.FromRadians(Math.PI);

        return Math.Abs(angle) < 1e-9 ? Angle.FromRadians(0) : Angle.FromRadians(angle);
    }
}