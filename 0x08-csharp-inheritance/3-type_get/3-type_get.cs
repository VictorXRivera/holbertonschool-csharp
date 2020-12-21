using System;
using System.Reflection;

/// <summary> Object class </summary>
class Obj
{
    /// <summary> Method to print objects </summary>
    public static void Print(object myObj)
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (var info in myObj.GetType().GetProperties())
        {
            Console.WriteLine(info.Name);
        }

        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (var info in myObj.GetType().GetMethods())
        {
            Console.WriteLine(info.Name);
        }
    }
}