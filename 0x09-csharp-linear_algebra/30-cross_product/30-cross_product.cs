using System;

/// <summary> vector math class </summary>
class VectorMath
{
    /// <summary> 3d vector cross product method </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
         if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] product = new double[vector1.Length];
            product[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
            product[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
            product[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
            return product;
        }
        return new double[] { -1 };
    }
}
