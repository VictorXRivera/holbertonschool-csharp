using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> new_list = new LinkedList<int>();

        if (size < 0)
        {
            return (new_list);
        }

        for (int element = 0; element < size; element++)
        {
            Console.WriteLine(element);
            new_list.AddLast(element);
        }
        
        return (new_list);
    }
}