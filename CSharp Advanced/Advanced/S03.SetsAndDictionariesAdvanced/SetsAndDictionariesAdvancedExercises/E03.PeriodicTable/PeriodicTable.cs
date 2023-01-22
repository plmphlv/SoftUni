using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.PeriodicTable
{
    internal class PeriodicTable
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < loops; i++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (string element in elements)
                {
                    set.Add(element);
                }
            }

            set = set.OrderBy(x => x).ToHashSet();

            Console.WriteLine(String.Join(" ", set));
        }
    }
}