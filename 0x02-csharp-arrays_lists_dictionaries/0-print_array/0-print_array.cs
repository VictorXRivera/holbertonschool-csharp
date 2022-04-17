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


        for (var num = 0; num < array1.Length; num++)
        {
            Console.Write(num);
            if (num < array1.Length - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return array1;
    }
}