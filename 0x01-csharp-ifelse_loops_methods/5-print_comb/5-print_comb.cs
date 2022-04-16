using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        while(number <= 98)
        {
            Console.Write("{0:00}, ", number);
            number++;
        }
        if (number == 99)
        {
            Console.Write("{0}\n", number);
        }
    }
}