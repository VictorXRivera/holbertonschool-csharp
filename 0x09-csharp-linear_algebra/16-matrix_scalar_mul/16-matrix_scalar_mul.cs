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
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return new double[,] {{-1}};
        
        for (int one = 0; one < matrix.GetLength(0); one++)
        {
            for (int two = 0; two < matrix.GetLength(0); two++)
            {
                scalar *= matrix[one, two];
            }
        }
        return matrix;
    }
}
