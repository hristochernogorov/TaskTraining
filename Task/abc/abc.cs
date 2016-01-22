using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        int max = Math.Max( Math.Max(A, B), C);
        int min = Math.Min(Math.Min(A, B), C);
        double expression = (A + B + C);
        double arithmetic = expression / 3;
       

        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine("{0:F3}",arithmetic);

    }
}

