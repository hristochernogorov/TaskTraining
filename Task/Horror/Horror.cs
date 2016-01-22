using System;

class Horror
{
    static void Main()
    {
        string text = Console.ReadLine();
        int amount = 0;
        int sum = 0;
        int position = 0;
        foreach (char symbol in text)
        {
            if (position % 2 == 0)
            {
                if (Char.IsDigit(symbol))
                {
                    sum += symbol - '0';
                    amount++;
                }     
            }
            position++;
        }
        Console.WriteLine("{0} {1}",amount,sum);
    }
}

