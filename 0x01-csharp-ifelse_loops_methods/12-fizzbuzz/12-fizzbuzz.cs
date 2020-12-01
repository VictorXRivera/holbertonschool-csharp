using System;

class Fizzbuzz
{
    static void Main()
    {
        for (int num = 1; num <= 100; num++)
        {
            if (num % 15 == 0)
            {
                Console.Write("Fizzbuzz ");
            }
            else if (num % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else if (num % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else
            {
                Console.Write("{0} ", num);
            }
        }
        Console.WriteLine();
    }
}