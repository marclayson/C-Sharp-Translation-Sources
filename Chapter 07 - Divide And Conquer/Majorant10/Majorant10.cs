﻿namespace Majorant10
{
    using System;

    public class Majorant10
    {
        internal static void Main()
        {
            char majority;
            char[] array = { 'A', 'C', 'A', 'C', 'C', 'B', 'B', 'C', 'C', 'C', 'B', 'C', 'A', };
            FindMajority(array, out majority);
            Console.WriteLine("Мажорант: {0}", majority);
        }

        private static void FindMajority<T>(T[] array, out T majority)
        {
            int size = array.Length;
            do
            {
                int currentCounter = 0;
                for (int i = 1; i < size; i += 2)
                {
                    if (array[i - 1].Equals(array[i]))
                    {
                        array[currentCounter++] = array[i];
                    }
                }

                if ((currentCounter & 1) == 0)
                {
                    array[currentCounter++] = array[size - 1];
                }

                size = currentCounter;
            }
            while (size > 1);
            majority = array[0];
        }
    }
}