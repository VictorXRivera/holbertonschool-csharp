using System;

class Line
{
    public static void PrintLine(int length)
    {
        Console.WriteLine("{0}$", length > 0 ? new String('_', length) : "" );
    }
}