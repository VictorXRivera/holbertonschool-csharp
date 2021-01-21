using System;

/// <summary>
/// matrix math class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Nethod that adds two matrices and returns resulting matrix
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] negative = {{-1}};
        if (matrix1.Length != matrix2.Length)
            return negative;
        if (matrix1.GetLength(0) < 2 || matrix2.GetLength(0) < 2 || matrix1.GetLength(0) > 3 || matrix2.GetLength(0) > 3)
            return negative;
        
        for (int one = 0; one < matrix1.GetLength(0); one++)
        {
            for (int two = 0; two < matrix2.GetLength(1); two++)
            {
                matrix1[one, two] = matrix1[one, two] + matrix2[one, two];
            }
        }
        return matrix1;
    }
}
