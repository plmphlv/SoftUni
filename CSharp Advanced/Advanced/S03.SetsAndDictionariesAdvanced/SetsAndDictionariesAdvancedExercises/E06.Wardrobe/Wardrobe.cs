using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.Wardrobe
{
    internal class Wardrobe
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothesByColor = new Dictionary<string, Dictionary<string, int>>();

            string[] separators = { " -> ", "," };
            for (int i = 0; i < loops; i++)
            {
                string[] tokens = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (!clothesByColor.ContainsKey(tokens[0]))
                {
                    clothesByColor[tokens[0]] = new Dictionary<string, int>();
                }

                for (int j = 1; j < tokens.Length; j++)
                {
                    if (!clothesByColor[tokens[0]].ContainsKey(tokens[j]))
                    {
                        clothesByColor[tokens[0]].Add(tokens[j], 0);
                    }

                    clothesByColor[tokens[0]][tokens[j]]++;
                }

            }

            string[] filter = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in clothesByColor)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothing in color.Value)
                {
                    string item = $"* {clothing.Key} - {clothing.Value}";

                    if (color.Key == filter[0] && clothing.Key == filter[1])
                    {
                        item += " (found!)";
                    }

                    Console.WriteLine(item);
                }
            }
        }
    }
}