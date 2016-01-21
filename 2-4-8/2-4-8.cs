using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int result = 0;

        if (B == 2)
        {
            result = A % C;
        }
        else if (B == 4)
        {
            result = A + C;
        }
        else if (B == 8)
        {
            result = A * C;
        }

        if (result % 4 == 0)
        {
            Console.WriteLine(result / 4);
        }
        else
        {
            Console.WriteLine(result % 4);
        }
        Console.WriteLine(result);
    }
}

