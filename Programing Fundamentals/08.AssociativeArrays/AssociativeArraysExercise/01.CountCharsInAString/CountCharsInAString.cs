using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    internal class CountCharsInAString
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (string item in words)
            {

                for (int i = 0; i < item.Length; i++)
                {

                    if (!chars.ContainsKey(item[i]))
                    {
                        chars[item[i]] = 0;
                    }
                    chars[item[i]]++;

                }

            }

            foreach (var ch in chars)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}