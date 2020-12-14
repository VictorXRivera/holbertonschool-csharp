using System;
using System.Collections.Generic;
using static System.Console;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int h = 0;
        if (myList.Count == 0)
            return h;

        try
        {
            for (h = 0; h < n; h++)
                Console.WriteLine(myList[h]);
        }
        catch (System.ArgumentOutOfRangeException) { }

        return h;
    }
}