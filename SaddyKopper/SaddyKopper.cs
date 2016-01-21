using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        string text = Console.ReadLine();

        int transformation = 0;
        bool transformed = true;
        while (text.Length > 1)     
        {
            int sum = 0;
            BigInteger product = 1;
            int position = 0;
            foreach (var symbol in text)
            {
                if (position % 2 == 0)
                {
                    int number = symbol - '0';
                    sum += number;
                }
                product *= sum;
                position++;
            }

            product /= sum;
            transformation++;

            text = product.ToString();

            if (transformation == 10)
            {
                transformed = false;
                break;
            }
        }

        if (transformed)
        {
            Console.WriteLine(transformation);
            Console.WriteLine(text);

        }
        else
        {
            Console.WriteLine(text);
        }


    }
}





