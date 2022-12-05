using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class EmojiDetector
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"([:|*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            Regex emojiRegex = new Regex(emojiPattern);
            Regex numberRegex = new Regex(@"\d");

            string text = Console.ReadLine();

            MatchCollection coolFactorNums = numberRegex.Matches(text);
            MatchCollection emojies = emojiRegex.Matches(text);

            int coolFactor = 1;

            foreach (Match item in coolFactorNums)
            {
                coolFactor *= int.Parse(item.Value.ToString());
            }

            List<string> list = new List<string>();

            foreach (Match emoji in emojies)
            {
                string emojiName = emoji.Groups["emoji"].Value.ToString();

                int currEmojiCoolnes = 0;

                for (int i = 0; i < emojiName.Length; i++)
                {
                    currEmojiCoolnes += (int)emojiName[i];
                }

                if (currEmojiCoolnes >= coolFactor)
                {
                    list.Add(emoji.Value.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {coolFactor}");
            Console.WriteLine($"{emojies.Count} emojis found in the text.");
            Console.WriteLine("The cool ones are:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}