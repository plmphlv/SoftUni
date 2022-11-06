using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountRealNumbers
{
    internal class CountRealNumbers
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {

                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }

                counts[number]++;

            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }

        }
    }
}