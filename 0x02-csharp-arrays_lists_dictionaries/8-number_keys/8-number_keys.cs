using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        Dictionary<string, string>.KeyCollection my_dict = myDict.Keys;
        
        int i = 0;
        foreach (var key in myDict)
        {
            i++;
        }
        return (i);
    }
}