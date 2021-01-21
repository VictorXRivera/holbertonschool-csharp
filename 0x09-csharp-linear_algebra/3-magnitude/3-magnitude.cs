using System;
using System.Linq;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Count() < 2 || vector.Count() > 3)
            return (-1);
        
        for (int v = 0; v < vector.Count(); v++)
        {
            vector[v] *= vector[v];
        }
        return Math.Round(Math.Sqrt(Math.Abs(vector.Sum())), 2);
    }
}