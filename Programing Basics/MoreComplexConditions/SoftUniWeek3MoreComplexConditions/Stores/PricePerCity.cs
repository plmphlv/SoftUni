using System;

namespace Stores
{
    internal class PricePerCity
    {
        static void Main(string[] args)
        {
            string shopItem = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double price = 0;

            switch (city)
            {
                case "Sofia":
                    if (shopItem == "coffee")
                        price = 0.5;
                    else if (shopItem == "water")
                        price = 0.8;
                    else if (shopItem == "beer")
                        price = 1.2;
                    else if (shopItem == "sweets")
                        price = 1.45;
                    else if (shopItem == "peanuts")
                        price = 1.6;
                    price = price * qty;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "Plovdiv":
                    if (shopItem == "coffee")
                        price = 0.4;
                    else if (shopItem == "water")
                        price = 0.7;
                    else if (shopItem == "beer")
                        price = 1.15;
                    else if (shopItem == "sweets")
                        price = 1.30;
                    else if (shopItem == "peanuts")
                        price = 1.5;

                    price = price * qty;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "Varna":
                    if (shopItem == "coffee")
                        price = 0.45;
                    else if (shopItem == "water")
                        price = 0.7;
                    else if (shopItem == "beer")
                        price = 1.1;
                    else if (shopItem == "sweets")
                        price = 1.35;
                    else if (shopItem == "peanuts")
                        price = 1.55;

                    price = price * qty;
                    Console.WriteLine($"{price:f2}");
                    break;
                default:
                    Console.WriteLine("You are retarded!");
                    break;
            }
        }
    }
}
