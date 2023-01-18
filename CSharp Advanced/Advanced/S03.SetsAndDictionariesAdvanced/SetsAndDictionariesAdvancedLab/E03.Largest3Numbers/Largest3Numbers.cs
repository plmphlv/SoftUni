using System;
using System.Linq;

namespace E03.Largest3Numbers
{
    internal class Largest3Numbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}