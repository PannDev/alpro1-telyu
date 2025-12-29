using System;
class Program
{
    static void Main()
    {
        //prob: fibonanci
        // 0 1 1 2 3
        // 0 1 1 2 3
        int a = 0, b = 1;
        int banyak = int.Parse(Console.ReadLine());
        for (int i = 0; i < banyak; i++)
        {
            Console.WriteLine(a);
            int angkaNext = a + b;
            a = b;
            b = angkaNext;
        }

    }
}