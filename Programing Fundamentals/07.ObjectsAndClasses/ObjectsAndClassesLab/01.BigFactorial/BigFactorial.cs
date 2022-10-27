﻿using System;
using System.Numerics;

namespace _01.BigFactorial
{
    internal class BigFactorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}