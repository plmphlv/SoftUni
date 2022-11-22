using System;
using System.Text;

namespace _04.CaesarCipher
{
    internal class CaesarCipher
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder encryptedWord = new StringBuilder();

            foreach (char letter in word)
            {
                int newSymbolCode = (int)letter + 3;
                encryptedWord.Append((char)newSymbolCode);
            }

            Console.WriteLine(encryptedWord);
        }
    }
}