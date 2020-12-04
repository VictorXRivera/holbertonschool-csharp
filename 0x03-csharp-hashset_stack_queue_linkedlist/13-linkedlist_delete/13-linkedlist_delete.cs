using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        var node = myLList.First;
        int i;

        for (i = 0; i < index && i < myLList.Count; i++)
        {
            node = node.Next;
        }
        if (i == index)
            myLList.Remove(node);
    }
}