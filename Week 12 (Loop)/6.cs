using System;
class Program
{
    static void Main()
    {
        // prime number
        int num = int.Parse(Console.ReadLine());
        if (num == 2)
        {
            Console.WriteLine("Prima");
        }
        else if (num % 2 == 1)  {
            Console.WriteLine("Prima");
        } else {
            Console.WriteLine("Bukan Prima");
        }
    }
}