﻿using System;

class Program
{
    static void Main(string[] args)
    {
        for (int num = 0; num <= 98; num++)
        {
            Console.WriteLine("{0} = 0x{0:x1}", num);
        }
    }
}