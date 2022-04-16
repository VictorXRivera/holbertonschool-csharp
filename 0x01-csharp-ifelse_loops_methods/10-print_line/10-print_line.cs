class Line
{
    public static void PrintLine(int length)
    {
        int iterator = 0;
        while (iterator < length)
        {
            Console.Write('_');
            iterator++;
        }
        Console.WriteLine();
    }
}