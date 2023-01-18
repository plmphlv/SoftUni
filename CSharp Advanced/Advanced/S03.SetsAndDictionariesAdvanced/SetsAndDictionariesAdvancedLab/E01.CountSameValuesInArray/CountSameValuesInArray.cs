using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.CountSameValuesInArray
{
    internal class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            double[] doubles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Dictionary<double, int> counts = new Dictionary<double, int>();

            foreach (var item in doubles)
            {
                if (!counts.ContainsKey(item))
                {
                    counts[item] = 0;
                }
                counts[item]++;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}