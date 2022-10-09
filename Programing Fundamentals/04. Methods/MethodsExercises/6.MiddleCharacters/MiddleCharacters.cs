using System;

namespace _6.MiddleCharacters
{
    internal class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string middleCharacters = MiddleCharactersFinder(word);
            Console.WriteLine(middleCharacters);
        }

        static string MiddleCharactersFinder(string word)
        {
            char[] chars = word.ToCharArray();
            string middleChars = string.Empty;
            int middleIndex = (chars.Length % 2 == 0) ? chars.Length / 2 : (chars.Length - 1)/2;

            if (chars.Length % 2 != 0)
            {
                middleChars += word[middleIndex];
            }
            else
            {
                middleChars += word[(middleIndex - 1)];
                middleChars +=  word[(middleIndex)];
            }

            return middleChars;
        }
    }
}