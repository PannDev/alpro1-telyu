using System;
class Program
{
    static void Main()
    {
        //input 5
        // output 15
        // 1+2+3+4+5
        int num = int.Parse(Console.ReadLine());
        int res = 0;
        for (int i = 1; i <= num; i++)
        {
            res += i;
        }
        Console.WriteLine(res);
    }
}