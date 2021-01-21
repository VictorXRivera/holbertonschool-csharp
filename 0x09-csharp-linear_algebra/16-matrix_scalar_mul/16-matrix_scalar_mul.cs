using System;
/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that multiples matrix by scalar and returns new matrix
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] negative = {{-1}};
        if (!matrix.Length)
        {
            return negative;
        }
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
        {
            return negative;
        }
        for (int v = 0; v < matrix.GetLength(0); v++)
        {
            for (int r = 0; r < matrix.GetLength(1); r++)
            {
                matrix[v, r] = matrix[v, r] * scalar;
            }
        }
        return matrix;
    }
}
