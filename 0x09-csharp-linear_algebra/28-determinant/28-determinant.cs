using System;

/// <summary> matrix math class </summary>
class MatrixMath
{
    /// <summary> method that calculates the determinant of a matrix. </summary>
    public static double Determinant(double[,] matrix)
    {
        int matrix_row = matrix.GetLength(0);
        int matrix_column = matrix.GetLength(1);

        if (matrix_row != matrix_column)
            return -1;

        if (matrix_row == 2)
            return Math.Round((matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]), 2);

        if (matrix_row == 3)
        {
            double v = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            double x = matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            double r = matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return Math.Round((v - x + r), 2);
        }
        return -1;
    }
}
