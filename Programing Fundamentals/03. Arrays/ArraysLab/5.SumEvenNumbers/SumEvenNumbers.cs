﻿using System;
using System.Linq;

namespace _5.SumEvenNumbers
{
    internal class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}