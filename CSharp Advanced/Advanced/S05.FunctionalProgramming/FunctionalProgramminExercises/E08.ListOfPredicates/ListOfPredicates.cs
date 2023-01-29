using System;
using System.Collections.Generic;
using System.Linq;

namespace E08.ListOfPredicates
{
    internal class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var item in numbers)
            {
                predicates.Add(n => n % item == 0);
            }

            List<int> list = new List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                list.Add(i);
            }

            foreach(var item in list)
            {
                bool isDivisable = true;

                foreach (var match in predicates)
                {
                    if (!match(item))
                    {
                        isDivisable = false;
                        break;
                    }
                }

                if (isDivisable)
                {
                    Console.Write($"{item} ");
                }
            }

        }
    }
}