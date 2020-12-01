using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num = 0; num < 100; num++)
            {
                Console.Write("{0}, ", num.ToString("00"));
                if (num == 99)
                {
                    Console.Write("{0}\n", num);
                }
            }
        }
    }
}
