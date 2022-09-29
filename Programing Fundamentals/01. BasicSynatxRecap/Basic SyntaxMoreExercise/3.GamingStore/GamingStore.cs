using System;

namespace _3.GamingStore
{
    internal class GamingStore
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            string gameName;
            double totalSpent = 0;

            while ((gameName = Console.ReadLine()) != "Game Time")
            {
                double gamePrice;
                switch (gameName)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (money >= gamePrice)
                {
                    money -= gamePrice;
                    totalSpent += gamePrice;
                    Console.WriteLine($"Bought {gameName}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${money:f2}");
        }
    }
}
