using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Race
    {
        static void Main(string[] args)
        {

            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> contestants = new Dictionary<string, int>();


            foreach (string participant in participants)
            {
                if (!contestants.ContainsKey(participant))
                {
                    contestants.Add(participant, 0);
                }
            }

            string namePattern = @"(?:[A-Za-z]+)";
            string kilometersPattern = @"(?:\d+)";

            Regex nameRegex = new Regex(namePattern);
            Regex kilometersRegex = new Regex(kilometersPattern);

            string command;
            while ((command = Console.ReadLine()) != "end of race")
            {
                MatchCollection nameMatch = nameRegex.Matches(command);
                StringBuilder name = new StringBuilder();

                foreach (Match letter in nameMatch)
                {
                    name.Append(letter.Value);
                }

                string nameKey = name.ToString();

                if (contestants.ContainsKey(nameKey))
                {
                    MatchCollection kmMatch = kilometersRegex.Matches(command);
                    StringBuilder kilometersSb = new StringBuilder();

                    foreach (Match digit in kmMatch)
                    {
                        kilometersSb.Append(digit.Value);
                    }

                    string kilometers = kilometersSb.ToString();

                    for (int i = 0; i < kilometers.Length; i++)
                    {
                        contestants[nameKey] += int.Parse((kilometers[i].ToString()));
                    }
                }
            }

            List<string> results = contestants.OrderByDescending(kp => kp.Value).Select(kp => kp.Key).ToList();


            Console.WriteLine($"1st place: {results[0]}");
            Console.WriteLine($"2nd place: {results[1]}");
            Console.WriteLine($"3rd place: {results[2]}");

        }
    }
}