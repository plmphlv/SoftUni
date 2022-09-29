using System;

namespace _11.Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double total = 0;
            for (int i = 1; i <= orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double orderPrice = ((daysInMonth * capsuleCount) * pricePerCapsule);
                total += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}