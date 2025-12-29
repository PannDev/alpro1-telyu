using System;
class Program
{
    // gimana cara buat function
    int gcd(int a, int b){
        if (b == 0)
        return a;
        return gcd(b, a % b);
    }
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(gcd(a, b));
    }
}