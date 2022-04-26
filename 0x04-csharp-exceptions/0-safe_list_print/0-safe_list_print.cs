using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        for (int element = 0; element < n; element++)
        {
            try
            {
                Console.WriteLine(myList[element]);
            }

            catch (ArgumentOutOfRangeException)
            {
                return (element);
            }
        }
        return(n);
    }
}