using System;

namespace _02.CharacterMultiplier
{
    internal class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringSum(input[0], input[1]);
        }

        public static void StringSum(string wordOne, string wordTwo)
        {
            int sum = 0;
            int minLenght = Math.Min(wordOne.Length, wordTwo.Length);

            for (int i = 0; i < minLenght; i++)
            {
                sum += wordOne[i] * wordTwo[i];
            }

            string longestWord = wordOne;
            if (wordOne.Length < wordTwo.Length)
            {
                longestWord = wordTwo;
            }

            for (int i = minLenght; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }

            Console.WriteLine(sum);

        }
    }
}