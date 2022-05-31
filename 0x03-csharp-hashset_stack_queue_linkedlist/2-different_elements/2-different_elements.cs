using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> new_list = list1.FindAll(item => !list2.Contains(item));
        List<int> compared_list = list2.FindAll(item => !list1.Contains(item));
        new_list.AddRange(compared_list);
        new_list.Sort();
        return(new_list);
    }
}