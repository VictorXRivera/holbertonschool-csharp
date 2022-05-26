using System;
///<summary>MatrixMath class</summary>
class MatrixMath
{
    ///<summary>Multiply matrices</summary>
    ///<return>-1 if matrix cannot be multiplied</return>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int m1_row = matrix1.GetLength(0);
		int m1_col = matrix1.GetLength(1);
		int m2_row = matrix2.GetLength(0);
		int m2_col = matrix2.GetLength(1);
		if (m1_col == m2_row)
		{
			double[,] result = new double[m1_row, m2_col];
			for (int i = 0; i < m1_row; i++)
			{
				for (int j = 0; j < m2_col; j++)
				{
					for (int k = 0; k < m1_col; k++)
					{
						result[i, j] += matrix1[i, k] * matrix2[k, j];
					}
				}
			}
			return result;
		}
		return new double[,] { { -1 } };
    }
}