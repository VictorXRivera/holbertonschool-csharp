using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack.Count <= 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }

        bool value = true;
        value = (aStack.Contains(search));
        Console.WriteLine($"Stack contains \"{search}\": {value}");

        if (value)
        {
            while (aStack.Pop() != search);
        }
        aStack.Push(newItem);
        return aStack;
    }
}