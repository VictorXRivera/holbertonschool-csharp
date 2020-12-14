using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> div_list = new List<int> ();
        for (int h = 0; h < listLength; h++)
        {
            try
            {
                int result = list1[h] / list2[h];
                div_list.Add(result);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                div_list.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return div_list;

    }
}