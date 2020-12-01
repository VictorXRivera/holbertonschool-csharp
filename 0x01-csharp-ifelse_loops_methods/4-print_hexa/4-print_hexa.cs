using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num = 0; num <= 98; num++)
            {
                Console.Write("{0} = 0x{0:x}\n", num);
            }
        }
    }
}