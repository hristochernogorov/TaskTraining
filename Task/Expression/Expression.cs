using System;

class Expression
{
    static void Main()
    {
        string expression = Console.ReadLine();
        
        decimal result = 0;
        bool inBracket = false;
        char currentOperator = '+';

        foreach (char symbol in expression)
        {
            if (symbol == '(')
            {
                inBracket = true;
            }

            if (symbol == '+' ||
                symbol == '=' ||
                symbol == '*' ||
                symbol == '/' )
            {
                currentOperator = symbol;
            }

            if (char.IsDigit(symbol))
            {
                int curentNumber = symbol - '0';
                switch (currentOperator)
                {
                    case '+': result += curentNumber; break;
                    case '-': result -= curentNumber; break;
                    case '*': result *= curentNumber; break;
                    case '/': result /= curentNumber; break;

                }
            }
        }
        Console.WriteLine("{0:F2}",result);
    }
}

