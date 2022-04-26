using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> new_list = new List<int>();

        for (int n = 0; n < listLength; n++)
        {
            try
            {
                new_list.Add(list1[n] / list2[n]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                new_list.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return new_list;
    }
}