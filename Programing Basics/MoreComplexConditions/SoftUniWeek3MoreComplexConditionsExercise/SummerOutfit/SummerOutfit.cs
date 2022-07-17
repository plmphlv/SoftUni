using System;

namespace SummerOutfit
{
    internal class SummerOutfit
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit = string.Empty;
            string shoes = string.Empty;

            switch (timeOfDay)
            {
                case "Morning":
                    if (temp <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temp >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
                    break;
                case "Afternoon":
                    if (temp <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (temp >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
                    break;
                case "Evening":
                    if (temp <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temp >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
                    break;
                default:
                    break;
            }
        }
    }
}
