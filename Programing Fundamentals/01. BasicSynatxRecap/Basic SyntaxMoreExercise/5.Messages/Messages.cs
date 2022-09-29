using System;

namespace _5.Messages
{
    internal class Messages
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= cycles; i++)
            {
                string command = Console.ReadLine();
                int letterCodeInput = int.Parse(command);

                int mainDigit = letterCodeInput % 10;
                int codeLenght = command.Length;

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = (offset + codeLenght) - 1;

                int letterCode = 97 + letterIndex;

                if (letterCode == 91)
                {
                    letterCode = 32;
                }

                char letter = Convert.ToChar(letterCode);
                word += letter;
            }

            Console.WriteLine(word);
        }
    }
}