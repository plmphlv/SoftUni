using System;
using System.Text;

namespace _02.RepeatStrings
{
    internal class RepeatStrings
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach(string word in words)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}