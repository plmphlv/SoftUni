using System;

namespace _3.CharactersInRange
{
    internal class CharactersInRange
    {
        static void Main(string[] args)
        {
            int starningSymbolCode = (int)(char.Parse(Console.ReadLine()));
            int endSymbolCode = (int)(char.Parse(Console.ReadLine()));

            if (starningSymbolCode > endSymbolCode)
            {
                int buff = starningSymbolCode;
                starningSymbolCode = endSymbolCode;
                endSymbolCode = buff;
            }

            CharacterPrinter(starningSymbolCode, endSymbolCode);
        }

        static void CharacterPrinter(int start, int end)
        {
            for (int i = start + 1; i < end; i++)
            {
                char symbol = (char)i;
                Console.Write($"{symbol} ");
            }
        }
    }
}