using System;

/// <summary>
/// Matrix math class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method to multiply methods
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int matrix1Rows = matrix1.GetLength(0);
        int matrix1Cols = matrix1.GetLength(1);
        int matrix2Rows = matrix2.GetLength(0);
        int matrix2Cols = matrix2.GetLength(1);

        if (matrix1Cols != matrix2Rows)
            return new double[,] { { -1 } };

        double[,] product = new double[matrix1Rows, matrix2Cols];
        for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++)
        {
            for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++)
            {
                for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++)
                {
                    product[matrix1_row, matrix2_col] +=
                      matrix1[matrix1_row, matrix1_col] *
                      matrix2[matrix1_col, matrix2_col];
                }
            }
        }
        return product;
    }
    
    /// <summary>
    /// Method that rotates matrix by angle using radian
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double cos_angle = Math.Cos(angle);
        double sin_angle = Math.Sin(angle);

        double[,] rotate_operation = {
            {cos_angle, -sin_angle},
            {sin_angle, cos_angle},
        };

        double[,] rotated_matrix = new double [matrix.GetLength(0), matrix.GetLength(1)];
        double[,] negative = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return negative;
        
        rotated_matrix = Multiply(rotate_operation, matrix);

        return rotated_matrix;
    }
}
