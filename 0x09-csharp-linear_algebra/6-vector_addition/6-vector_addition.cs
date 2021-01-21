using System;
using System.Linq;

/// <summary>
/// Vector math class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that adds two vectors and returns new vector
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] negative_one = {-1};
        if (vector1.Length < 2 || vector2.Length < 2 || vector1.Length > 3 || vector2.Length > 3)
        {
            return negative_one;
        }
        
        double[] new_vector = new double[vector1.Length];
        for (int v = 0; v < vector1.Length; v++)
        {
            new_vector[v] = vector1[v] + vector2[v];
        }
        return new_vector;
    }
}
