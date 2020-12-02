using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> new_list = new List<bool>();
        foreach (int element in myList)
        {
            if (element % 2 == 0)
            {
                new_list.Add(true);
            }
            else
            {
                new_list.Add(false);
            }
        }
        return new_list;
    }
}