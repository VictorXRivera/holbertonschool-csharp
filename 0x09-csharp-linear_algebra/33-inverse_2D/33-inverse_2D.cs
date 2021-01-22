using System;

/// <summary> matrix math method </summary>
class MatrixMath
{
    /// <summary> method that calculates the inverse of a 2D matrix and returns the resulting matrix. </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int matrix_row = matrix.GetLength(0);
        int matrix_column = matrix.GetLength(1);
        double [,] negative_one = new double[,] {{-1}};

        if (matrix == null || matrix_row != 2 || matrix_column != 2)
            return negative_one;

        double[,] matrix_2d = new double[2, 2];

        matrix_2d[0, 0] = matrix[1, 1];
        matrix_2d[0, 1] = -1 * matrix[0, 1];
        matrix_2d[1, 0] = -1 * matrix[1, 0];
        matrix_2d[1, 1] = matrix[0, 0];

        double operations = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);

        if (operations == 0)
            return negative_one;
        
        double[,] inverse = new double[2, 2];

        for (int i = 0; i < 2; i += 1)
        {
            for (int j = 0; j < 2; j += 1)
                inverse[i, j] = Math.Round((1 / operations) * matrix_2d[i, j], 2);
        }
        return inverse;
    }
}