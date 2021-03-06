﻿using System;

public class MersennePrimeNumbersFinder
{
    private const uint MersennePrimeNumbersCount = 10;
    private static uint[] primeNumbers = { 2, 3, 5, 7, 13, 17, 19, 31, 61, 89 };
    private static uint[] number = new uint[200];
    private static uint k = 0;

    internal static void Main()
    {
        for (uint i = 1; i <= primeNumbers.Length; i++)
        {
            CalculatePerfectNumber(i, primeNumbers[i - 1]);
        }
    }

    private static void CalculatePerfectNumber(uint s, uint m)
    {
        k = 1;
        number[0] = 1;
        for (uint i = 0; i < m; i++)
        {
            DoubleN(); // Това са делители от вида 2^i
        }

        number[0]--; // Последната цифра със сигурност е измежду { 2, 4, 6, 8 }

        for (uint i = 0; i < m - 1; i++)
        {
            DoubleN();
        }

        Console.Write("{0}-то съвършено число е = ", s);
        PrintPerfectNumber(); // Отпечатва поредното съвършено число
    }

    private static void DoubleN()
    {
        uint carry = 0, temp = 0;
        for (uint i = 0; i < k; i++)
        {
            temp = (number[i] * 2) + carry;
            number[i] = temp % 10;
            carry = temp / 10;
        }

        if (carry > 0)
        {
            number[k++] = carry;
        }
    }

    private static void PrintPerfectNumber()
    {
        for (uint i = k; i > 0; i--)
        {
            Console.Write(number[i - 1]);
        }

        Console.WriteLine();
    }
}
