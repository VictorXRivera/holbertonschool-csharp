using System;
class Program
{
    static void Main(string[] args)
    {
        double[] vector = {14, -2, 0};
        double[] vector1 = {-3, 23, 50};
        double[] vector2 = {8, -11};
        double[] vector3 = {-4, 9};
        double res;
        double res1;

        res = VectorMath.DotProduct(vector, vector1);
        res1 = VectorMath.DotProduct(vector2, vector3);

        Console.WriteLine(res);
        Console.WriteLine(res1);
    }
}