using System;

namespace MyMath
{
    /// <summary> Matrix class </summary>
    public class Matrix
    {
        /// <summary> Dividing a matrix method </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;
            
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
 
            int Len_0 = matrix.GetLength(0);
            int Len_1 = matrix.GetLength(1);
            int [,] new_matrix = new int[Len_0, Len_1];

            for (int i = 0; i < Len_0; i++)
            {
                for (int j = 0; j < Len_1; j++)
                {
                    new_matrix[i, j] = matrix[i, j] / num;
                }
            }
            return (new_matrix);
        }
    }
}
