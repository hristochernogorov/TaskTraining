using System;

class TextToNumber
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        long result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsNumber(text[i]))
            {
                result *= text[i] - '0';
            }
            else if (char.IsLetter(text[i]))
            {
                result += char.ToUpper(text[i]) - 65;
            }
            else if ((text[i]) =='@')
            {
                break;               
            }
            else
            {
                result %= M;
            }

        }
        Console.WriteLine(result);
    }

}

