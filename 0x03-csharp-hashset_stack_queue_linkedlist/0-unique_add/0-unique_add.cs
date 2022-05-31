using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        var unique = myList.Distinct();

        int sum = 0;

        foreach (int num in unique)
        {
            sum += num;
        }

        return (sum);
    }
}