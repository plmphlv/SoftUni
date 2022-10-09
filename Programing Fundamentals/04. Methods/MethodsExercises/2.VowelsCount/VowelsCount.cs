using System;
using System.Linq;

namespace _2.VowelsCount
{
    internal class VowelsCount
    {
        static void Main(string[] args)
        {
            string myWord = Console.ReadLine();

            VowelCounter(myWord);
        }

        static void VowelCounter(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            int numberOfVowels = 0;

            foreach (char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    numberOfVowels++;
                }
            }

            Console.WriteLine(numberOfVowels);
        }
    }
}