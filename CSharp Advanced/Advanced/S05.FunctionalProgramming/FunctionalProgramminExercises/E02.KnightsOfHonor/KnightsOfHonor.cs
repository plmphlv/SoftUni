using System;

namespace E02.KnightsOfHonor
{
    internal class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            Action<string[], string> print = (words, title) =>
            {
                foreach (var word in words)
                {
                    Console.WriteLine($"{title} {word}");
                }
            };

            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            print(words, "Sir");

        }
    }
}