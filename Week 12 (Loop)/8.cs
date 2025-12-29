using System;
class Program
{
    static void Main()
    { int n = int.Parse(Console.ReadLine());
		int hasil = 0;
        while (n > 0)
        {
			
            hasil = hasil * 10 + (n % 10);
            n /= 10;
		
        }
		Console.Write(hasil);

        /*
        Input: 1234
        Output: 4321

321
hasil = 1
n= 32

hasil = 


        Input: 120
        Output: 21 (because 021 as integer is 21)
        */
    }
}