﻿using System;

internal class hedonia
{
    private const int Max = 100;
    private const int NotCalculated = 2;
    private const string CheckString = "NNNNNNNNECINNxqpCDNNNNNwNNNtNNNNs"; /* Изречение за проверка */


    private static int[,] f = new int[Max, Max]; /* Целева функция */
    private static int n; /* Дължина на изречението */

    private static void Init()
    {
        n = CheckString.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                f[i, j] = NotCalculated;
            }
        }
    }

    private static int Check(int start, int end)
    {
        int k;
        if (f[start, end] != NotCalculated)
        {
            return f[start, end];
        }
        else
        {
            /* Вместо следващите 2 реда */
            if (start == end)
            {
                f[start, end] = (CheckString[start] >= 'p' && CheckString[start] <= 'z') ? 1 : 0;
            }
            else if (CheckString[start] == 'N')
            {
                f[start, end] = Check(start + 1, end);
            }
            else if (CheckString[start] == 'C' || CheckString[start] == 'D'
                     || CheckString[start] == 'E' || CheckString[start] == 'I')
            {
                k = start + 1;
                while (k < end && !(Check(start + 1, k) != 0 && Check(k + 1, end) != 0))
                {
                    k++;
                }
                f[start, end] = (k != end) ? 1 : 0;
            }
            else
            {
                f[start, end] = 0;
            }

            return f[start, end];
        }
    }

    private static void Main()
    {
        Init();
        Console.WriteLine("Изречението е {0}", Check(0, n - 1) != 0 ? "правилно!" : "НЕПРАВИЛНО!!!");
    }
}