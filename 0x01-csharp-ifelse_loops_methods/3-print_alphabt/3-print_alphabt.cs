using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char alphabet;
            for (alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                if (alphabet != 'e' && alphabet != 'q')
                Console.Write(alphabet);
            }
        }
    }
}
