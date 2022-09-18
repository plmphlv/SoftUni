using System;

namespace _4.ReverseString
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversedString=string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedString +=word[i];
            }

            Console.WriteLine(reversedString);
        }
    }
}