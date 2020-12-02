using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.WriteLine();
        }
        int[] arrays = new int[size];
        for (int i = 0; i < size; i++)
        {
            if (i == size - 1)
            {
                Console.WriteLine(i);
                arrays[i] = i;
            }
            else
            {
                Console.Write("{0} ", i);
                arrays[i] = i;
            }
        }
        return arrays;
    }
}