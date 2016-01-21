using System;
using System.Globalization;
using System.Threading;

class Money
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int N = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        int allSheets = N * S;
        double realm = allSheets / 400.00;
        double result = realm * P;
        Console.WriteLine("{0:F3}",result);

    }
}

