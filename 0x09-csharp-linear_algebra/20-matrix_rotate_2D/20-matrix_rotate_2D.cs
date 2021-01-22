using System;

/// <summary>
/// Matrix math class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that rotates matrix by angle using radian
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] new_matrix = new double[2, 2];
        double[,] rotated_matrix = new double[,] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double operation;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};
        
        for (int v = 0; v < 2; v += 1)
        {
            for (int r = 0; r < 2; r += 1)
            {
                operation = 0;
                for (int x = 0; x < 2; x += 1)
                    operation = Math.Round(operation + (matrix[v, x] * rotated_matrix[x, r]), 2);
                new_matrix[v, r] = operation;
            }
        }
        return new_matrix;
    }
}
