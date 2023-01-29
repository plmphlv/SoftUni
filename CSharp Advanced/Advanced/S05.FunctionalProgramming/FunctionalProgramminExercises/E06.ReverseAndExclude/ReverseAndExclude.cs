using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.ReverseAndExclude
{
    internal class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            Func<List<int>, Predicate<int>, List<int>> reverseAndExclude = (numArr, divisableBy) =>
            {
                List<int> results = new List<int>();
                foreach (int num in numArr)
                {
                    if (!divisableBy(num))
                    {
                        results.Add(num);
                    }
                }

                Func<List<int>, List<int>> reverse = list =>
                {
                    List<int> reversed = new List<int>();

                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        reversed.Add(list[i]);
                    }

                    return reversed;
                };

                results = reverse(results);

                return results;
            };


            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int div =int.Parse(Console.ReadLine());

            numbers = reverseAndExclude(numbers, x => x % div == 0);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}