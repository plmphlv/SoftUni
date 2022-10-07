using System;

namespace _5.Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int orderQuantity = int.Parse(Console.ReadLine());

            OrderSum(order, orderQuantity);
        }

        static void OrderSum(string itemName, int itemQuantity)
        {
            switch (itemName)
            {
                case "coffee":
                    Console.WriteLine($"{itemQuantity * 1.50:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{itemQuantity * 1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{itemQuantity * 1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{itemQuantity * 2.00:f2}");
                    break;
            }
        }
    }
}