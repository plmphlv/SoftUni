using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    internal class WordSynonyms
    {
        static void Main(string[] args)
        {

            int reads = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < reads; i++)
            {
                string word = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new List<string>();
                }

                synonyms[word].Add(Console.ReadLine());

            }

            foreach (var sy in synonyms)
            {
                Console.WriteLine($"{sy.Key} - {String.Join(", ", sy.Value)}");
            }

        }
    }
}