using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> my_copy = new Dictionary<string, int>(myDict);
        foreach (KeyValuePair<string, int> element in myDict)
        {
            my_copy[element.Key] = element.Value * 2;
        }
        return my_copy;
    }
}