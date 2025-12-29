using System;
class Program
{
    static void Main()
    {
        // problem faktorial
        // 5 * 4 * 3 * 2 * 1
        int num = int.Parse(Console.ReadLine());
        int res = 1;
        while (num > 0)
        {
            res *= num;
            num--;
        }
        Console.WriteLine(res);
    }
}