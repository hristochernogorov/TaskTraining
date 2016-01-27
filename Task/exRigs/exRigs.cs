using System;
using System.Text;

class exRigs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        char blank = '.';
        char full = '#';
        char ex = 'X';
        char leftSym = '\\';
        char rightSym = '/';

        StringBuilder sb = new StringBuilder();
        int size = 2 * n + 1;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (col - row <= d / 2 && col - row >= -d / 2 ||
                    col + row <= 2 * n + d / 2 && col + row >= 2 * n - d / 2)
                {
                    sb.Append(full);
                }
                else if ((col == n + d / 2 + 1 || col == n - (d / 2 + 1)) && row == n ||
                    (row == n + (d / 2 + 1) || row == n - (d / 2 + 1)) && col == n)
                {
                    sb.Append(ex);
                }
                else if (col - row == d / 2 + 1 ||
                    col - row == -(d / 2 + 1))
                {
                    sb.Append(leftSym);
                }
                else if (col + row == 2 * n + (d / 2 + 1) ||
                    col + row == 2 * n - (d / 2 + 1))
                {
                    sb.Append(rightSym);
                }
                else
                {
                    sb.Append(blank);
                }
            }

            if (row != size - 1)
            {
                sb.AppendLine();
            }
        }

        Console.WriteLine(sb);

    }
}






