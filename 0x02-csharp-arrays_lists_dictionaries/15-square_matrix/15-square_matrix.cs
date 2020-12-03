using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int row = myMatrix.GetLength(0);
        int column = myMatrix.GetLength(1);

        int[,] sq_value = new int[row, column];
        for (int h = 0; h < row; h++)
        {
            for (int b = 0; b < column; b++)
            {
                sq_value[h, b] = myMatrix[h, b] * myMatrix[h, b];
            }
        }
        return sq_value;
    }
}