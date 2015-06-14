﻿using System;

namespace Translations._2.brothers
{
    internal class alanbob
    {
        private const int MaxObjects = 100; /* Максимален брой предмети */
        private const int MaxValue = 200; /* Максимална стойност на отделен предмет */

        private static bool[] possible = new bool[MaxObjects * MaxValue]; /* Може ли да се получи сумата? */
        private static int[] objectValues = new int[] { 3, 2, 3, 2, 2, 77, 89, 23, 90, 11 };
        private const int n = 10; /* Общ брой на предметите за поделяне */

        private static void Solve()
        {
            int totalSum; /* Обща стойност на предметите за поделяне */
            int i, j;

            /* Пресмятаме totalSum */
            for (totalSum = i = 0; i < n; totalSum += objectValues[i++])
            {
                ;
            }
            possible[0] = true;

            /* Намиране на всевъзможните суми от стойности на подаръците */
            for (i = 0; i < n; i++)
            {
                for (j = totalSum; j + 1 > 0; j--)
                {
                    if (possible[j])
                    {
                        possible[j + objectValues[i]] = true;
                    }
                }
            }

            /* Намиране на най-близката до p/2 стойност */
            for (i = totalSum / 2; i > 1; i--)
            {
                if (possible[i])
                {
                    Console.WriteLine("сума за Алан: {0}, сума за Боб: {1}", i, totalSum - i);
                    return;
                }
            }
        }

        private static void Main()
        {
            Solve();
        }
    }
}