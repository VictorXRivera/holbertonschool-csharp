using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int space = 0; space < length; space++)
            {
                Console.WriteLine("{0}{1}$", new String(' ', space), length > 0 ? "\\" : "");
            }
        }
        Console.WriteLine();
    }
}