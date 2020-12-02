using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        for (int start = array.Length - 1; start >= 0; start--)
        {
            if (start == 0)
            {
                Console.WriteLine(array[start]);
                break;
            }
            Console.Write(array[start] + " ");
        }
    }
}