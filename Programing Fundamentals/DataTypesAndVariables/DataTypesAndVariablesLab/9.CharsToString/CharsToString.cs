using System;

namespace _9.CharsToString
{
    internal class CharsToString
    {
        static void Main(string[] args)
        {
            string word = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word += symbol;
            }

            Console.WriteLine(word);
        }
    }
}