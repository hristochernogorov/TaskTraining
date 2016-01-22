using System;

class NightmareCodeStreet

{
    static void Main()
    {
        string text = Console.ReadLine();
        int sumOdd = 0;
        int position = 0;
        int amount = 0;
        foreach (var symbol in text)
        {
            if (char.IsDigit(symbol))
            {
                if (position % 2 != 0)
                {
                    sumOdd += symbol - 48;
                    amount++;
                }
            }
            position++;
        }
        Console.WriteLine("{0} {1}", amount, sumOdd);
    }
}
