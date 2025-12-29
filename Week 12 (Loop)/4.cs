using System;
class Program
{
    static void Main()
    {
        /*
        Base (A)
        Exponent (B)
        */
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        // 2^3 = 2*2*2
        int res = 1;
        for (int i = 1; i <= b; i++)
        {
            res *= a;
        }
        Console.WriteLine(res);
    }
}