using System;

class symbolToNumber
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int addNumberForLetter = 1000;
        int addNumberForDigit = 500;
        decimal result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if ((char.IsLower(text[i])) || (char.IsUpper(text[i])))

            {
                result = text[i] * secretNumber + addNumberForLetter;
            }
            else if (char.IsNumber(text[i]))
            {
                result = text[i] + secretNumber + addNumberForDigit;
            }
            else
            {
                result = text[i] - secretNumber;
            }
            if (text[i] == '@')
            {
                break;
            }

            string printResult;

            if (i % 2 == 0)
            {
                result /= 100M;
                printResult = string.Format("{0:F2}", result);
            }
            else
            {
                result *= 100M;
                printResult = string.Format(result.ToString());

            }
            Console.WriteLine(printResult);

        }
    }
}

