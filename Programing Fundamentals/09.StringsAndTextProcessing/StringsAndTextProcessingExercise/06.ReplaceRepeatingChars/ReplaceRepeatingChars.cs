using System;

namespace _06.ReplaceRepeatingChars
{
    internal class ReplaceRepeatingChars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char currentLetter = ' ';

            foreach (var item in input)
            {
                if (item != currentLetter)
                {
                    Console.Write(item);
                    currentLetter = item;
                }
            }
        }
    }
}