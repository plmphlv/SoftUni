using System;

namespace _01.TheBiscuitFactory
{
    internal class TheBiscuitFactory
    {
        static void Main(string[] args)
        {
            int cokiesPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int rivalMonthlyQouta = int.Parse(Console.ReadLine());

            decimal totalProduct = 0m;

            for (int i = 1; i <= 30; i++)
            {
                decimal dailyProduce = cokiesPerDay * workers;

                if (i % 3 == 0)
                {
                    dailyProduce = Math.Floor(dailyProduce * 0.75m);
                }

                totalProduct += dailyProduce;
            }

            Console.WriteLine($"You have produced {totalProduct} biscuits for the past month.");


            string result = (totalProduct > rivalMonthlyQouta) ?
            $"You produce {((totalProduct - rivalMonthlyQouta) / rivalMonthlyQouta) * 100:f2} percent more biscuits." :
            $"You produce {((rivalMonthlyQouta - totalProduct) / rivalMonthlyQouta) * 100:f2} percent less biscuits.";


            Console.WriteLine(result);
        }
    }
}