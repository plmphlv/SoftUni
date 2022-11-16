﻿using System;

namespace _04.TextFilter
{
    internal class TextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach(string bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    text=text.Replace(bannedWord,new string('*',bannedWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}