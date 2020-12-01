using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num = 0; num <= 99; num++)
            {
                if (num != 99)
                {
                Console.Write(num.ToString("00"));
                Console.Write(", ");
                }
                else
                {
                    Console.Write("{0}\n", num);
                }
            }
        }
    }
}
