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
        double[,] negative_matrix = {{-1}};
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
        {
            return negative_matrix;
        }
        for (int one = 0; one < matrix.GetLength(0); one++)
        {
            for (int two = 0; two < matrix.GetLength(1); two++)
            {
                matrix[one, two] = matrix[one, two] + scalar;
            }
        }
        return matrix;
    }
}
