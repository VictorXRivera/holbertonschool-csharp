class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
        }
        
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] array1 = new int[size];

        for (int num = 0; num < size; num++)
        {
            array1[num] = num;
            Console.Write(array1[num]);

            if (num == size - 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
        return (array1);
    }
}