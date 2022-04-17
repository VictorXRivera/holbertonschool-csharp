class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        int[] array1 = new int[size];

        for (int num = 0; num < size; num++)
            array1[num] = num;
        
        foreach (var element in array1)
        {
            Console.Write(element);
            if (element != array1[array1.Length - 1])
                Console.Write(" ");
        }
        Console.WriteLine();
        return array1;
    }
}