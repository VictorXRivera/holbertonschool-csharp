using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        bool container = aStack.Contains(search);
        Console.WriteLine("Number of items: {0}", aStack.Count);
        Console.WriteLine("Top item: {0}", aStack.Peek());
        Console.WriteLine("Stack contains {0}: {1}", search, container);

        if (container)
        {
            int i = 0;
            foreach (string item in aStack)
            {
                i++;
                if (item == search)
                {
                    break;
                }
            }
            for (int j = 0; j < i; j++)
            {
                aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}