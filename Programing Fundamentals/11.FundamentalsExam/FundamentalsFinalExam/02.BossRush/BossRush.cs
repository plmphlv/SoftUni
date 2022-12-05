using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.BossRush
{
    internal class BossRush
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            string bossPattern = @"([|])(?<name>[A-Z]{4,})\1:(#)(?<title>[A-Z][a-z]+ [A-Z]*[a-z]+)\2";
            Regex bossFinder = new Regex(bossPattern);


            for (int i = 0; i < inputs; i++)
            {
                string boss = Console.ReadLine();

                Match bossMatch = bossFinder.Match(boss);

                if (bossMatch.Success)
                {
                    string bossName = bossMatch.Groups["name"].ToString();
                    string bossTite = bossMatch.Groups["title"].ToString();

                    Console.WriteLine($"{bossName}, The {bossTite}");
                    Console.WriteLine($">> Strength: {bossName.Length}");
                    Console.WriteLine($">> Armor: {bossTite.Length}");

                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }

        }
    }
}