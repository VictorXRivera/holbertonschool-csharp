using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        var max = myList.Aggregate((k, v) => k.Value > v.Value ? k : v).Key;
        return max;
    }
}