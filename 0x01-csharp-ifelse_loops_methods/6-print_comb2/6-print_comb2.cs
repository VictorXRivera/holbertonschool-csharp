using System;

class Program
{
    static void Main(string[] args)
    {
        for(int num = 0; num <=99; num++)
        {
            int firstdigit = num % 10;
            int seconddigit = num / 10;
            if(firstdigit != seconddigit && firstdigit > seconddigit)
            {
                if(num != 89)
                Console.Write("{0:00}, ", num);
                else
                Console.WriteLine("{0}", num);
            }
        }
    }
}