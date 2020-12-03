using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> sum = myList.ToHashSet();
        return sum.Sum();
    }
}