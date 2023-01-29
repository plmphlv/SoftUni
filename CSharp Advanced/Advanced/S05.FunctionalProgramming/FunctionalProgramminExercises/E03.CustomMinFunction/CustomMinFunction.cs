using System;
using System.Linq;

namespace E03.CustomMinFunction
{
    internal class CustomMinFunction
    {
        static void Main(string[] args)
        {
            Func<int[], int> minFinder = (ints) =>
            {
                int minNum = int.MaxValue;

                foreach (int i in ints)
                {
                    if (i < minNum)
                    {
                        minNum = i;
                    }
                }

                return minNum;
            };

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(minFinder(numbers));
        }
    }
}