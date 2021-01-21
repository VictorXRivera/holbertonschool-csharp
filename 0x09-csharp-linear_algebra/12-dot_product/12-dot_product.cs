using System;
using System.Linq;

/// <summary>
/// VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Dot product method
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
        {
            return -1;
        }
        if (vector1.Length < 2 || vector2.Length < 2 || vector1.Length > 3 || vector2.Length > 3)
        {
            return -1;
        }

        double product = 0;
        for (int v = 0; v < vector1.Length; v++)
        {
            double dot = vector1[v] * vector2[v];
            product = product + dot;
        }
        return product;
    }
}
