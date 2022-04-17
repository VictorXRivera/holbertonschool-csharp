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

        for (int num = 0; num < size; num++)
        {
            array1[num] = num;
        }

        Console.WriteLine("{0}", string.Join(" ", array1));
        return array1;
    }
}