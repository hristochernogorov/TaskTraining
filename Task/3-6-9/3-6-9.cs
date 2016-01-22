using System;

class Program
{
    static void Main()
    {
        long A = int.Parse(Console.ReadLine());
        long B = int.Parse(Console.ReadLine());
        long C = int.Parse(Console.ReadLine());
        long  R = 0;
        long secondR = 0;
        if (B == 3)
        {
            R = A + C;
        }
        else if (B == 6)
        {
            R = A * C;
        }
        else if (B == 9)
        {
            R = A % C;

        }

        if (R % 3 == 0)
        {
            secondR = R / 3;

            
        }
        else
        {
            secondR = R % 3;

        }
        Console.WriteLine(secondR);
        Console.WriteLine(R);
    }
   
}

