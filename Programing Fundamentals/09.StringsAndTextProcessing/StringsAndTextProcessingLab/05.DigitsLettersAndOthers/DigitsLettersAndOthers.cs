using System;

namespace _05.DigitsLettersAndOthers
{
    internal class DigitsLettersAndOthers
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string letters = string.Empty;
            string digits = string.Empty;
            string misc = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else
                {
                    misc += symbol;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(misc);
        }
    }
}