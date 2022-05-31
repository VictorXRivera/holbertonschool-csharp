using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> new_list = new List<int>();
        for (int c = 0; c < list1.Count; c++)
        {
            for (int n = 0; n < list2.Count; n++)
            {
                if (list1[c] == list2[n])
                {
                    new_list.Add(list1[c]);
                }
            }
        }
        return new_list;
    }
}