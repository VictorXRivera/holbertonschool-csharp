﻿int i;
for (i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write("FizzBuzz ");
    }
    else if (i % 3 == 0)
    {
        Console.Write("Fizz ");
    }
    else if (i % 5 == 0)
    {
        if (i == 100)
        {
            Console.WriteLine("Buzz");
        }
        else
        Console.Write("Buzz ");
    }
    else
    {
        Console.Write("{0} ", i);
    }
}