using System;

/// <summary> matrix math class </summary>
class MatrixMath
{
    /// <summary> method that shears a square 2D matrix by a given shear factor and returns the resulting matrix. </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return new double[,] {{-1}};

        double[,] new_matrix = new double[2, 2];

        if (direction == 'x' || direction == 'y')
        {
            if (direction == 'x')
            {
                new_matrix[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
                new_matrix[0, 1] = matrix[0, 1];
                new_matrix[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
                new_matrix[1, 1] = matrix[1, 1];

                return new_matrix;
            }
            else
            {
                new_matrix[0, 0] = matrix[0, 0];
                new_matrix[0, 1] = matrix[0, 1] + factor * matrix[0, 0];
                new_matrix[1, 0] = matrix[1, 0];
                new_matrix[1, 1] = matrix[1, 1] + factor * matrix[1, 0];

                return new_matrix;
            }
        }
        return new double[,] {{-1}};
    }
}
