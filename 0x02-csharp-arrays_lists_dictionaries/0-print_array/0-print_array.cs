class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] array1 = new int[size];

        if (size == 0)
        {
            Console.WriteLine();
            return array1;
        }
        
        for (int num = 0; num < size; num++)
        {
            array1[num] = num;
        }
        Console.WriteLine(String.Join(" ", array1));
        return array1;
    }
}