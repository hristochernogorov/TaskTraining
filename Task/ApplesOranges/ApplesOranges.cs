using System;

class ApplesOranges
{
    static void Main()
    {
        string n = (Console.ReadLine());
        long sumEven = 0;
        long sumOdd = 0;
        int position = 0;
        foreach (var symbol in n)
        {
            if (char.IsDigit(symbol))
            {
                if (symbol % 2 == 0)
                {
                    sumEven += symbol - 48;
                }
                else
                {
                    sumOdd += symbol - 48;
                }
            }

            position++;
        }

        if (sumOdd > sumEven)
        {
            Console.WriteLine("oranges {0}", sumOdd);
        }
        else if (sumEven > sumOdd)
        {
            Console.WriteLine("apples {0}", sumEven);
        }
        else
        {
            if (sumEven == sumOdd)
            {
                Console.WriteLine("both {0}", sumEven);
            }
        }
    }
}

