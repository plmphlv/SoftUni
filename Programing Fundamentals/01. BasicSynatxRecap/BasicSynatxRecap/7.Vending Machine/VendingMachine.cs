using System;

namespace _7.Vending_Machine
{
    internal class VendingMachine
    {
        static void Main(string[] args)
        {
            double money = 0;
            string comand1;
            while ((comand1 = Console.ReadLine()) != "Start")
            {
                double coin = double.Parse(comand1);
                switch (coin)
                {
                    case 0.1:
                        money += coin;
                        break;
                    case 0.2:
                        money += coin;
                        break;
                    case 0.5:
                        money += coin;
                        break;
                    case 1:
                        money += coin;
                        break;
                    case 2:
                        money += coin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }

            }

            string product;
            while ((product = Console.ReadLine()) != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (money >= 2.0)
                        {
                            Console.WriteLine($"Purchased nuts");
                            money -= 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (money >= 0.7)
                        {
                            Console.WriteLine($"Purchased water");
                            money -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (money >= 1.5)
                        {
                            Console.WriteLine($"Purchased crisps");
                            money -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (money >= 0.8)
                        {
                            Console.WriteLine($"Purchased soda");
                            money -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (money >= 1.0)
                        {
                            Console.WriteLine($"Purchased coke");
                            money -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}