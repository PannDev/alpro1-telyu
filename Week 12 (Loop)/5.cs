using System;
class Program
{
    static void Main()
    {
        // problem: print even (genap) num
        int end = int.Parse(Console.ReadLine());
        for (int i = 2; i <= end; i+= 2)
        {
            Console.WriteLine(i);
        }
    }
}