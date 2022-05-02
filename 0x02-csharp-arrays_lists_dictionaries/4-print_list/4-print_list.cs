using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        List<int> new_list = new List<int>();

        for (int n = 0; n < size; n++)
        {
            new_list.Add(n);
            if (n < size - 1)
            {
                Console.Write(new_list[n] + " ");
            }
            else
            {
                Console.Write(new_list[n]);
            }
        }
        Console.WriteLine("");
        return (new_list);
    }
}