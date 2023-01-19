using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.ProductShop
{
    internal class ProductShop
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string command;

            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] strings = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (!shops.ContainsKey(strings[0]))
                {
                    shops[strings[0]] = new Dictionary<string, double>();

                }

                if (!shops[strings[0]].ContainsKey(strings[1]))
                {
                    shops[strings[0]][strings[1]] = 0;
                }

                shops[strings[0]][strings[1]] = double.Parse(strings[2]);
            }

            shops = shops.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            foreach (var s in shops)
            {
                Console.WriteLine($"{s.Key}->");

                foreach (var v in s.Value)
                {
                    Console.WriteLine($"Product: {v.Key}, Price: {v.Value:f1}");
                }
            }
        }
    }
}