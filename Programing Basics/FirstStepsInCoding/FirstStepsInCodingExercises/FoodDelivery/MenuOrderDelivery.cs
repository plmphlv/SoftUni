using System;

namespace FoodDelivery
{
    class MenuOrderDelivery
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegiMenu = int.Parse(Console.ReadLine());

            double menuCost = chickenMenu * 10.35 + fishMenu * 12.40 + vegiMenu * 8.15;
            double totalCost = (menuCost * 0.20) + menuCost + 2.50;
            Console.WriteLine(totalCost);
        }
    }
}
