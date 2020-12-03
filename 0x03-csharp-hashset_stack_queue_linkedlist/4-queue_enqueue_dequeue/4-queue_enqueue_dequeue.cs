using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count <= 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }

        bool value = true;
        value = (aQueue.Contains(search));
        Console.WriteLine($"Queue contains \"{search}\": {value}");

        if (value)
        {
            while (aQueue.Dequeue() != search);
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}