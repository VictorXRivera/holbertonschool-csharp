using System;
///<summary>MatrixMath class</summary>
class MatrixMath
{
	///<summary>2D Matrix rotation</summary>
	///<return>-1 if not a Matrix or rotated matrix</return>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		if (matrix.GetLength(1) > 2)
			return new double[,] { { -1 } };
		double[,] rotate = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
		double[,] rotatedMatrix = new double[2, 2];

		for (int i = 0; i < 2; i++)
			for (int j = 0; j < 2; j++)
				for (int k = 0; k < 2; k++)
					rotatedMatrix[i, j] = Math.Round(rotatedMatrix[i, j] + (matrix[i, k] * rotate[k, j]), 2);
		return rotatedMatrix;
	}
}