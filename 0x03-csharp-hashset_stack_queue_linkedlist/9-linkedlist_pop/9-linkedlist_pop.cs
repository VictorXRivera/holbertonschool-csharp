using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int top_node;
        if (myLList.Count == 0)
            return 0;
        top_node = myLList.First.Value;
        myLList.RemoveFirst();
        return top_node;
    }
}