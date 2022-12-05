using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Furniture
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);
            List<string> furniture = new List<string>();
            decimal totalSum = 0m;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    furniture.Add(match.Groups["furniture"].Value.ToString());
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal qty = decimal.Parse(match.Groups["quantity"].Value);

                    totalSum += price * qty;

                }
            }

            Console.WriteLine("Bought furniture:");
            Console.WriteLine(string.Join(Environment.NewLine, furniture));
            Console.WriteLine($"Total money spend: {totalSum:f2}");

        }
    }
}