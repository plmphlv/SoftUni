using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    internal class OddOccurrences
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (string word in words)
            {

                if (!dic.ContainsKey(word))
                {
                    dic[word] = 0;
                }
                dic[word]++;

            }

            foreach (var word in dic)
            {

                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }

            }

        }
    }
}