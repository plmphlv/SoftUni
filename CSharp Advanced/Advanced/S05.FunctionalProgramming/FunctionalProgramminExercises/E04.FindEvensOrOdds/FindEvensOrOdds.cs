using System;
using System.Linq;

namespace E04.FindEvensOrOdds
{
    internal class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Predicate<int> dividability = GetDividability(Console.ReadLine());

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (dividability(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        private static Predicate<int> GetDividability(string condition)
        {
            if (condition == "odd")
            {
                return x => x % 2 != 0;
            }
            else
            {
                return x => x % 2 == 0;
            }
        }
    }
}