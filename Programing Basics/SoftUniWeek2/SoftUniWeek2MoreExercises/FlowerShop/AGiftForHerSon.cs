using System;

namespace FlowerShop
{
    internal class AgiftForHerSon
    {
        static void Main(string[] args)
        {
            int magnoliaCount = int.Parse(Console.ReadLine());
            int hyacinthCount = int.Parse(Console.ReadLine());
            int roseCount = int.Parse(Console.ReadLine());
            int cactusCount = int.Parse(Console.ReadLine());
            double presentCost = double.Parse(Console.ReadLine());
            double leftover = 0;

            double orderCost = (magnoliaCount * 3.25) + (hyacinthCount * 4) + (roseCount * 3.50) + (cactusCount * 8);
            orderCost = orderCost - (orderCost * 0.05);

            if (orderCost>=presentCost)
            {
                leftover = Math.Floor(orderCost - presentCost);
                Console.WriteLine($"She is left with {leftover} leva.");
            }
            else
            {
                leftover = Math.Ceiling(presentCost - orderCost);
                Console.WriteLine($"She will have to borrow {leftover} leva.");
            }
        }
    }
}
