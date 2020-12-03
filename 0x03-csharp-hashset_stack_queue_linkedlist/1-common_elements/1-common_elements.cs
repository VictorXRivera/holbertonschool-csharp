using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> l1 = new HashSet<int>(list1);
        HashSet<int> l2 = new HashSet<int>(list2); 
        List<int> s_list = new List<int>();

        l1.IntersectWith(l2);
        foreach (int num in l1)
        {
            s_list.Add(num);
        }
        s_list.Sort();
        return s_list;
    }
}