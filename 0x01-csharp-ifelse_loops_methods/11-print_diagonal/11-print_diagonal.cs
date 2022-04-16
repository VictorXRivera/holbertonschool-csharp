class Line
{
    public static void PrintDiagonal(int length)
    {
        
        for(int iterator1 = 0; iterator1 < length; iterator1++)
        {
            for (int iterator2 = 0; iterator2 < iterator1; iterator2++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        Console.WriteLine("");
    }
}