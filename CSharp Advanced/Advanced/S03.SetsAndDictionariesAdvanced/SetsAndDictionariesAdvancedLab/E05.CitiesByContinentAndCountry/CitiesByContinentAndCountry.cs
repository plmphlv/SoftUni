using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.CitiesByContinentAndCountry
{
    internal class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < loops; i++)
            {
                string[] counrtyBalls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!continents.ContainsKey(counrtyBalls[0]))
                {
                    continents[counrtyBalls[0]] = new Dictionary<string, List<string>>();
                }

                if (!continents[counrtyBalls[0]].ContainsKey(counrtyBalls[1]))
                {
                    continents[counrtyBalls[0]][counrtyBalls[1]] = new List<string>();
                }

                continents[counrtyBalls[0]][counrtyBalls[1]].Add(counrtyBalls[2]);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($" {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}