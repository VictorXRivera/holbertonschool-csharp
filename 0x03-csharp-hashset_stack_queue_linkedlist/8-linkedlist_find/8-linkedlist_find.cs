using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int counter = 0;
        foreach (int num in myLList)
        {
            if (num == value)
            return counter;
            counter++;
        }
        return -1;
    }
}