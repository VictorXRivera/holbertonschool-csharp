using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h < 9; h++)
            {
                for (int b = h + 1; b < 10; b++)
                {
                    Console.Write("{0}{1}{2}", h, b, (h < 8 ? ", ": ""));
                }
            }
            Console.WriteLine();
        }
    }
}
