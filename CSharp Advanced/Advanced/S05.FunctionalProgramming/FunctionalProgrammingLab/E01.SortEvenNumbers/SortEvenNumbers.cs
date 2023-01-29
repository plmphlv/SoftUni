using System;
using System.Linq;

namespace E01.SortEvenNumbers
{
    internal class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = (x) => int.Parse(x);

            int[] numbs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parser).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();

            Console.WriteLine(String.Join(", ", numbs));
        }
    }
}