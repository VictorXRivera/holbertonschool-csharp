using System;

/// <summary> matrix math class </summary>
class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        int matrix_row = matrix.GetLength(0);
        int matrix_column = matrix.GetLength(1);

        if (matrix == null || matrix_row == 0 || matrix_column == 0)
            return new double[,]{};
        
        double[,] transposed = new double[matrix_column, matrix_row];

        for (int i = 0; i < matrix_row; i += 1)
        {
            for (int j = 0; j < matrix_column; j += 1)
                transposed[j, i] = matrix[i, j];
        }
        return transposed;
    }
}
