using System;

namespace E01.ActionPoint
{
    internal class ActionPoint
    {
        static void Main(string[] args)
        {
            Action<string[]> print = (words) =>
            {
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
            };

            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            print(words);
        }
    }
}