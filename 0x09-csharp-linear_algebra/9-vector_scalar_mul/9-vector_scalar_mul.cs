using System;
using System.Linq;
/// <summary>
/// Vector math class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that multiples vector by scalar and returns new vector
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] negative_one = {-1};
        if (vector.Length < 2 || vector.Length > 3)
        {
            return negative_one;
        }
        for (int v = 0; v < vector.Length; v++)
        {
            vector[v]= vector[v] * scalar;
        }
        return vector;
    }
}
