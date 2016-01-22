using System;

namespace AngryFemale
{
    class AngryFemale
    {
        static void Main()
        {
            string n = Console.ReadLine();
            int sumEven = 0;
            int sumOdd = 0;
            
            foreach ( var symbol  in n)
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
            }

            if (sumEven>sumOdd)
            {
                Console.WriteLine("right {0}",sumEven);
            }
            else if (sumOdd>sumEven)
            {
                Console.WriteLine("left {0}",sumOdd);
            }
            else if (sumEven == sumOdd)
            {
                Console.WriteLine("straight {0}",sumEven);
            }
          
        }
    }
}
