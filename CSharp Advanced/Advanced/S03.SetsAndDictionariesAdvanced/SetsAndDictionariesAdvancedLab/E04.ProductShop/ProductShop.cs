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

                string shop = strings[0];
                string product = strings[1];
                double price = double.Parse(strings[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, 0);
                }

                shops[shop][product] = price;
            }

            shops = shops.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}