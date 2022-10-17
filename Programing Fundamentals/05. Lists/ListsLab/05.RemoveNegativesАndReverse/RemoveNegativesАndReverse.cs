using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesАndReverse
{
    internal class RemoveNegativesАndReverse
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();

            ints.RemoveAll(n => n < 0);
            ints.Reverse();

            if (ints.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", ints));
            }
        }
    }
}